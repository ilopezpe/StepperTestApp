# StepperTestApp
Reads position of a rotation stage (degrees), and commands a stepper motor to change the current position.

The software sends serial commands to an arduino running the following serial i/o script (https://github.com/ilopezpe/StepperTestApp/blob/master/polarizerControl.ino). 

The arduino is continously being polled for the current position, and waiting for serial commands. The arduino controles movement with acceleration and deceleration, and incorporates backlash compensation.
In the current iteration, rotation past 180 degrees is not possible.

![App Image](https://github.com/ilopezpe/StepperTestApp/blob/master/StepperTestApp.png)



This software can be tested with any serial port device, e.g. Arduino. 

[![HitCount](http://hits.dwyl.com/ilopezpe/{project}.svg)](http://hits.dwyl.com/ilopezpe/{project})
