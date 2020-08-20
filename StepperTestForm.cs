using System;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

// this app reads units (degree), and requests an arduino to move a motor some # of steps.
// requires polarizerControl software to be installed on an arduino
//
namespace StepperApp
{
    public partial class StepperApp : Form
    {
        private long tx_counter = 0;
        private int stepsPerUnit;

        Boolean loadConfig;

        public StepperApp()
        {
            InitializeComponent();
            getPorts();
            InitializeTimers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelControl.Enabled = false;
            buttonStop.Enabled = false;
            numericUpDown1.Value = 0;
            numericUpDown1.Maximum = 365;
            numericUpDown1.Minimum = -365;
        }

        // populate available com ports
        private void getPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPorts.Items.Add(port);
            }
        }

        // timers for polling serial port
        private void InitializeTimers()
        {
            timer1.Interval = 930;
            timer1.Tick += new EventHandler(timer1_tick);

            timer2.Interval = 200;
            timer2.Tick += new EventHandler(timer2_tick);
        }

        // request motor status, i.e. ready or busy
        private void timer1_tick(object sender, EventArgs e)
        {
            sendtx("STATUS");
        }

        // request current position
        private void timer2_tick(object sender, EventArgs e)
        {
            if (loadConfig == true)
            {
                sendtx("CONFIG");
            }
            else
            {
                sendtx("READ");
            }
        }

        // refresh available ports
        private void buttonRefreshPorts_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                comboBoxPorts.Items.Clear();
                getPorts();
            }
        }

        private void buttonPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false && comboBoxPorts.SelectedIndex != -1)
            {
                //Serial Port Settings
                serialPort1.PortName = comboBoxPorts.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.RtsEnable = true;
                serialPort1.DtrEnable = false; //do not enable! will reset arduino

                //Timeout settings
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                try
                {
                    serialPort1.Open();
                    serialPort1.DiscardOutBuffer();
                    serialPort1.DiscardInBuffer();

                    // update panels
                    labelMotorStatus.Text = "Ready";
                    labelMotorStatus.BackColor = Color.Lime;
                    labelMotorStatus.Update();

                    buttonPort.Text = "Close Port";
                    buttonPort.BackColor = SystemColors.Control;

                    comboBoxPorts.Enabled = false;
                    buttonRefreshPorts.Enabled = false;
                    panelControl.Enabled = true;
                    buttonStop.Enabled = true;
                    numericUpDown1.Focus();

                    loadConfig = true;

                    timer1.Enabled = true;
                    timer2.Enabled = true;

                }
                catch
                {
                    labelMotorStatus.Text = "Port Unavailable!";
                    labelMotorStatus.Update();
                }
            }
            else
            {
                try
                {
                    closePort();
                }
                catch
                {
                }
            }
            // do nothing
        }

        // write to serial port with error handling 
        private void sendtx(string s)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(s + "\r\n");
                    tx_counter++;
                }
                catch
                {
                    labelMotorStatus.Text = "Port Unavailable!";
                    labelMotorStatus.Update();
                    closePort();
                }
            }

            if (!serialPort1.IsOpen)
            {
                //unexpected close
                comboBoxPorts.Items.Clear();
                getPorts();
                closePort();
            }
        }

        // carefully close port 
        private void closePort()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            // update panels
            labelMotorStatus.Text = "NC";
            labelMotorStatus.BackColor = Color.Red;
            labelMotorStatus.Update();

            buttonPort.Text = "Open Port";
            buttonPort.BackColor = Color.Lime;

            comboBoxPorts.Enabled = true;
            buttonRefreshPorts.Enabled = true;
            panelControl.Enabled = false;
            buttonStop.Enabled = false;

            serialPort1.Close();
            serialPort1.Dispose();
        }

        private delegate void InvokeDelegate(string s);
        private async void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data;
            data = serialPort1.ReadLine();

            if (char.IsNumber(data[0]) == true && loadConfig == true)
            {
                try
                {
                    loadConfig = false;
                    this.BeginInvoke(new InvokeDelegate(UpdateConfig), new object[] { data });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
            if (loadConfig == false)
            {
                this.BeginInvoke(new InvokeDelegate(UpdatePos), new object[] { data });
            }
            await Task.Delay(100);
        }

        private void UpdateConfig(string data)
        {
            string[] parts = data.Trim().Split(',');
            textBoxInfo1.Text = parts[0];
            textBoxInfo2.Text = parts[1];
            textBoxInfo3.Text = parts[2];

            stepsPerUnit = int.Parse(textBoxInfo1.Text);

            numericUpDown1.Increment = 1 / (decimal)stepsPerUnit;
        }

        private void UpdatePos(string data)
        {
            string s = data.Trim();

            if (int.TryParse(s, out _) == true)
            {
                textBoxInfo4.Text = toUnit(s);
            }

            if (int.TryParse(s, out _) == false && s == "Ready")
            {
                labelMotorStatus.Text = data;
                labelMotorStatus.BackColor = Color.Lime;
                labelMotorStatus.Update();
                buttonInchLeft.Enabled = true;
                buttonInchRight.Enabled = true;
                buttonMove.Enabled = true;
                buttonSetPos.Enabled = true;
                numericUpDown1.Enabled = true;
            }
            else if (int.TryParse(s, out _) == false && s == "Busy")
            {
                labelMotorStatus.Text = data;
                labelMotorStatus.BackColor = Color.Red;
                labelMotorStatus.Update();
                buttonInchLeft.Enabled = false;
                buttonInchRight.Enabled = false;
                buttonMove.Enabled = false;
                buttonSetPos.Enabled = false;
                numericUpDown1.Enabled = false;
            }
        }

        // converts to desired unit
        private string toUnit(string s_steps)
        {
            float n_steps = float.Parse(s_steps);
            float unit = n_steps / stepsPerUnit;
            return unit.ToString("F", CultureInfo.InvariantCulture);
        }

        private float toStep(float n_targetPos)
        {
            float n_steps = n_targetPos * stepsPerUnit;
            Math.Round(n_steps, 2);
            return n_steps;
        }

        // absolute move command
        private void buttonMove_Click(object sender, EventArgs e)
        {
            float n_targetPos = (float)numericUpDown1.Value;

            if (n_targetPos != float.Parse(textBoxInfo4.Text))
            {
                float n_steps = n_targetPos * stepsPerUnit;
                sendtx("MOVETO " + n_steps.ToString());
                numericUpDown1.Value = 0;
            }
        }

        // send relative move commands w/o backlash compensation
        private void buttonInchLeft_Click(object sender, EventArgs e)
        {
            sendtx("MOVE -1");
        }

        private void buttonInchRight_Click(object sender, EventArgs e)
        {
            sendtx("MOVE 1");
        }

        // reset home position (zero)
        private void buttonSetPos_Click(object sender, EventArgs e)
        {
            sendtx("SETPOS 0");
            numericUpDown1.Value = 0;
        }

        // emergency stop with deceleration to save position
        private void buttonStop_Click(object sender, EventArgs e)
        {
            sendtx("STOP");
        }

        // quit application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                closePort();
            }
            StepperApp.ActiveForm.Close();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float n_step = toStep((float)numericUpDown1.Value);

            if (Math.Round(n_step, 2) % 1 != 0)
            {
                numericUpDown1.Value = decimal.Parse(textBoxInfo4.Text);
                numericUpDown1.Update();
                return;
            }
            {
                numericUpDown1.BackColor = Color.White;
                numericUpDown1.Update();
                return;
            }
        }
    }
}
