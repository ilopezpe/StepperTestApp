// Polarizer Controller
//
// A rotation stage coupled to a stepper motor+driver is driven by serial commands
// from an arduino controller. The arduino accepts serial commands in degrees, and requests 
// movement in # of steps. The movement of the rotation stage in degrees depends on 
// the gear reduction and the steps per rotation of the motor. These values should be 
// hardcoded into the arduino controller and matched to the equipment.
//
// tested on arduino nano using ATMEGA328 (old bootloader)
// the CH340 USB/SERIAL chip on arduino nano clones require a driver 
// https://learn.sparkfun.com/tutorials/how-to-install-ch340-drivers/all

//arduino settings
const int stepPin = 2;
const int dirPin = 3;
const int enablePin = 4;

//motor settings are hardcoded
const int stepPerUnit = 50; //0.02 deg step resolution
const int backlashSteps = 50;

//global variables
boolean busy = 0;
boolean CCW = 0;
float targetPos;

//create steppermotor object --- connected to nano pin 2 (STEP) and pin 3(DIR)
AccelStepper stepper(AccelStepper::DRIVER, stepPin, dirPin);

//initialize serial buffer
char serial_command_buffer_[32];
SerialCommands serial_commands_(&Serial, serial_command_buffer_, sizeof(serial_command_buffer_), "\r\n", " ");

//serial command handler for unknown commands
void cmd_unrecognized(SerialCommands* sender, const char* cmd)
{
  sender->GetSerial()->print("ERROR: Unrecognized command [");
  sender->GetSerial()->print(cmd);
  sender->GetSerial()->println("]");
}

void motor_init()
{
  //stepper motor configuration
  stepper.setPinsInverted(1, 0, 1); //inverts direction and enable pins
  stepper.setEnablePin(4);
  stepper.setMinPulseWidth(25);
  stepper.setMaxSpeed(2000);
  stepper.setAcceleration(20.0); 
}

//PRINT CONFIG
void cmd_motor_config(SerialCommands* sender){
  sender->GetSerial()->print(stepPerUnit);
  sender->GetSerial()->print(",");
  sender->GetSerial()->print(backlashSteps);
  sender->GetSerial()->print(",");
  sender->GetSerial()->print(stepper.maxSpeed());
  sender->GetSerial()->print("\r\n");
}

// RELATIVE MOVE
// NO BACKLASH COMPENSATION
void cmd_motor_move(SerialCommands* sender){
  char* relStep_str = sender->Next();
  if (relStep_str == NULL){
    sender->GetSerial()->println("ERROR: Enter targeted move (units)");
    return;
  }
  busy = true;
  long N_relStep = atoi(relStep_str);
  stepper.move(N_relStep);
}

// ABSOLUTE MOVES 
// WITH BACKLASH COMPENSATION
// Accepts target position in base units, e.g. degrees
// Converts base units to steps
void cmd_motor_moveto(SerialCommands* sender){
  char* targetPos_str = sender->Next();
  if (targetPos_str == NULL){
    sender->GetSerial()->println("ERROR: Enter target position (units)");
    return;
  }
  busy = true;
  targetPos = atoi(targetPos_str);
  
  if (targetPos > stepper.currentPosition()) { 
    stepper.moveTo(targetPos);
  } 
  else {
    CCW = true;
    stepper.moveTo(targetPos-backlashSteps);
  }
}

// STOP USING DECELERATION
void cmd_motor_stop(SerialCommands* sender){
  stepper.stop();
}

// READ CURRENT POSITION
void cmd_motor_readpos(SerialCommands* sender){
  sender->GetSerial()->println(stepper.currentPosition());
}

// CHANGE CURRENT POSITION
void cmd_motor_setpos(SerialCommands* sender){
  char* setpos_str = sender->Next();
  if (setpos_str == NULL){
    sender->GetSerial()->println("ERROR: Enter a target position (unit)");
    return;
  }
  long N_steps = atoi(setpos_str);
  sender->GetSerial()->println("O.K.");
  stepper.setCurrentPosition(N_steps);
}

// CHANGE MAX SPEED
void cmd_motor_setfreq(SerialCommands* sender){
  char* setfreq_str = sender->Next();
  if (setfreq_str == NULL){
    sender->GetSerial()->println("ERROR: Enter a frequency (steps per sec)");
    return;
  }
  long f_steps = atoi(setfreq_str);
  sender->GetSerial()->println("O.K.");
  stepper.setMaxSpeed(f_steps);
}

// CHANGE ACCELERATION
void cmd_motor_setaccel(SerialCommands* sender){
  char* setaccel_str = sender->Next();
  if (setaccel_str == NULL){
    sender->GetSerial()->println("ERROR: Enter an acceleration (steps per sec^2)");
    return;
  }
  long N_accel = atoi(setaccel_str);
  sender->GetSerial()->println("O.K.");
  stepper.setAcceleration(N_accel);
}

// MOTOR STATUS
void cmd_motor_status(SerialCommands* sender){
  if (stepper.isRunning()){
     sender->GetSerial()->println("Busy"); 
  }
  else {
    sender->GetSerial()->println("Ready"); 
  }
}

// ENABLE AND DISABLE OUTPUTS 
void cmd_motor_enable(SerialCommands* sender)
{
  stepper.enableOutputs(); 
  sender->GetSerial()->println("Enabled");
}

void cmd_motor_disable(SerialCommands* sender)
{
  stepper.disableOutputs(); 
  sender->GetSerial()->println("Disabled");
}

void cmd_list_commands(SerialCommands* sender)
{
  sender->GetSerial()->println("MOVE,MOVETO,STOP,READ");
  sender->GetSerial()->println("SETPOS,SETSPEED,SETACCEL");
  sender->GetSerial()->println("CONFIG,STATUS,ENABLE,DISABLE");
}


//Note: Commands are case sensitive
SerialCommand cmd_motor_config_("CONFIG", cmd_motor_config);
SerialCommand cmd_motor_move_("MOVE", cmd_motor_move);
SerialCommand cmd_motor_moveto_("MOVETO", cmd_motor_moveto);
SerialCommand cmd_motor_stop_("STOP", cmd_motor_stop);
SerialCommand cmd_motor_readpos_("READ", cmd_motor_readpos);
SerialCommand cmd_motor_setpos_("SETPOS", cmd_motor_setpos);
SerialCommand cmd_motor_setfreq_("SETSPEED", cmd_motor_setfreq);
SerialCommand cmd_motor_setaccel_("SETACCEL", cmd_motor_setaccel);
SerialCommand cmd_motor_status_("STATUS", cmd_motor_status);
SerialCommand cmd_motor_enable_("ENABLE", cmd_motor_enable);
SerialCommand cmd_motor_disable_("DISABLE", cmd_motor_disable);
SerialCommand cmd_list_commands_("LIST", cmd_list_commands);

void setup() 
{
  Serial.begin(9600,SERIAL_8N1);

  motor_init();

 // COM configuration
  serial_commands_.SetDefaultHandler(cmd_unrecognized);
  serial_commands_.AddCommand(&cmd_motor_move_);
  serial_commands_.AddCommand(&cmd_motor_moveto_);
  serial_commands_.AddCommand(&cmd_motor_stop_);
  serial_commands_.AddCommand(&cmd_motor_readpos_);
  serial_commands_.AddCommand(&cmd_motor_setpos_);
  serial_commands_.AddCommand(&cmd_motor_setfreq_);
  serial_commands_.AddCommand(&cmd_motor_setaccel_);
  serial_commands_.AddCommand(&cmd_motor_status_);
  serial_commands_.AddCommand(&cmd_motor_config_);
  serial_commands_.AddCommand(&cmd_motor_enable_);
  serial_commands_.AddCommand(&cmd_motor_disable_);
  serial_commands_.AddCommand(&cmd_list_commands_);
      
  Serial.println("Ready.");
}

void loop() 
{
  serial_commands_.ReadSerial();
  stepper.run();
    
  if (stepper.distanceToGo() != 0){
    serial_commands_.ReadSerial();
    //Serial.println(stepper.currentPosition());
  }

  if ((stepper.currentPosition() == targetPos-backlashSteps) && CCW==true){
    serial_commands_.ReadSerial();
    //Serial.println(stepper.currentPosition());
    stepper.moveTo(targetPos); 
  }

  if ((stepper.distanceToGo() == 0 ) && busy==true)
  {
    busy = false;
    CCW = false;
    Serial.println(stepper.currentPosition());
  }
}
