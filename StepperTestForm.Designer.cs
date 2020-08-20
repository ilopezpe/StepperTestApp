namespace StepperApp
{
    partial class StepperApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonRefreshPorts = new System.Windows.Forms.Button();
            this.buttonPort = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxInfo3 = new System.Windows.Forms.TextBox();
            this.textBoxInfo2 = new System.Windows.Forms.TextBox();
            this.textBoxInfo1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonInchRight = new System.Windows.Forms.Button();
            this.buttonInchLeft = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxInfo4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSetPos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMotorStatus = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelPorts = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelStepperInfo = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panelControl = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelPorts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelStepperInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(143, 29);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(80, 21);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.TabStop = false;
            // 
            // buttonRefreshPorts
            // 
            this.buttonRefreshPorts.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefreshPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshPorts.Location = new System.Drawing.Point(23, 29);
            this.buttonRefreshPorts.Name = "buttonRefreshPorts";
            this.buttonRefreshPorts.Size = new System.Drawing.Size(80, 20);
            this.buttonRefreshPorts.TabIndex = 0;
            this.buttonRefreshPorts.TabStop = false;
            this.buttonRefreshPorts.Text = "Refresh Ports";
            this.buttonRefreshPorts.UseVisualStyleBackColor = false;
            this.buttonRefreshPorts.Click += new System.EventHandler(this.buttonRefreshPorts_Click);
            // 
            // buttonPort
            // 
            this.buttonPort.BackColor = System.Drawing.Color.Lime;
            this.buttonPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPort.Location = new System.Drawing.Point(247, 22);
            this.buttonPort.Name = "buttonPort";
            this.buttonPort.Size = new System.Drawing.Size(100, 34);
            this.buttonPort.TabIndex = 1;
            this.buttonPort.Text = "Open Port";
            this.buttonPort.UseVisualStyleBackColor = false;
            this.buttonPort.Click += new System.EventHandler(this.buttonPort_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(196, 11);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 34);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Shutdown";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxInfo3
            // 
            this.textBoxInfo3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxInfo3.Location = new System.Drawing.Point(261, 40);
            this.textBoxInfo3.Name = "textBoxInfo3";
            this.textBoxInfo3.ReadOnly = true;
            this.textBoxInfo3.Size = new System.Drawing.Size(70, 20);
            this.textBoxInfo3.TabIndex = 16;
            this.textBoxInfo3.TabStop = false;
            this.textBoxInfo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInfo2
            // 
            this.textBoxInfo2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxInfo2.Location = new System.Drawing.Point(145, 40);
            this.textBoxInfo2.Name = "textBoxInfo2";
            this.textBoxInfo2.ReadOnly = true;
            this.textBoxInfo2.Size = new System.Drawing.Size(70, 20);
            this.textBoxInfo2.TabIndex = 15;
            this.textBoxInfo2.TabStop = false;
            this.textBoxInfo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInfo1
            // 
            this.textBoxInfo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxInfo1.Location = new System.Drawing.Point(28, 40);
            this.textBoxInfo1.Name = "textBoxInfo1";
            this.textBoxInfo1.ReadOnly = true;
            this.textBoxInfo1.Size = new System.Drawing.Size(70, 20);
            this.textBoxInfo1.TabIndex = 14;
            this.textBoxInfo1.TabStop = false;
            this.textBoxInfo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(263, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Max Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(140, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Backlash Steps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Steps per deg";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(145, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(99, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "deg";
            // 
            // buttonInchRight
            // 
            this.buttonInchRight.BackColor = System.Drawing.SystemColors.Control;
            this.buttonInchRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchRight.Location = new System.Drawing.Point(138, 118);
            this.buttonInchRight.Name = "buttonInchRight";
            this.buttonInchRight.Size = new System.Drawing.Size(50, 40);
            this.buttonInchRight.TabIndex = 7;
            this.buttonInchRight.TabStop = false;
            this.buttonInchRight.Text = "→";
            this.buttonInchRight.UseVisualStyleBackColor = false;
            this.buttonInchRight.Click += new System.EventHandler(this.buttonInchRight_Click);
            // 
            // buttonInchLeft
            // 
            this.buttonInchLeft.BackColor = System.Drawing.SystemColors.Control;
            this.buttonInchLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchLeft.Location = new System.Drawing.Point(65, 118);
            this.buttonInchLeft.Name = "buttonInchLeft";
            this.buttonInchLeft.Size = new System.Drawing.Size(50, 40);
            this.buttonInchLeft.TabIndex = 6;
            this.buttonInchLeft.TabStop = false;
            this.buttonInchLeft.Text = "←";
            this.buttonInchLeft.UseVisualStyleBackColor = false;
            this.buttonInchLeft.Click += new System.EventHandler(this.buttonInchLeft_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(103, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Inching";
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMove.Location = new System.Drawing.Point(247, 45);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(100, 34);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Target Position:";
            // 
            // textBoxInfo4
            // 
            this.textBoxInfo4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxInfo4.Location = new System.Drawing.Point(28, 54);
            this.textBoxInfo4.Name = "textBoxInfo4";
            this.textBoxInfo4.ReadOnly = true;
            this.textBoxInfo4.Size = new System.Drawing.Size(70, 20);
            this.textBoxInfo4.TabIndex = 18;
            this.textBoxInfo4.TabStop = false;
            this.textBoxInfo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Current Position:";
            // 
            // buttonSetPos
            // 
            this.buttonSetPos.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSetPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetPos.Location = new System.Drawing.Point(247, 118);
            this.buttonSetPos.Name = "buttonSetPos";
            this.buttonSetPos.Size = new System.Drawing.Size(100, 40);
            this.buttonSetPos.TabIndex = 8;
            this.buttonSetPos.TabStop = false;
            this.buttonSetPos.Text = "Set Home Position";
            this.buttonSetPos.UseVisualStyleBackColor = false;
            this.buttonSetPos.Click += new System.EventHandler(this.buttonSetPos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status :";
            // 
            // labelMotorStatus
            // 
            this.labelMotorStatus.AutoSize = true;
            this.labelMotorStatus.BackColor = System.Drawing.Color.Red;
            this.labelMotorStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMotorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotorStatus.Location = new System.Drawing.Point(227, 64);
            this.labelMotorStatus.MinimumSize = new System.Drawing.Size(100, 20);
            this.labelMotorStatus.Name = "labelMotorStatus";
            this.labelMotorStatus.Size = new System.Drawing.Size(100, 20);
            this.labelMotorStatus.TabIndex = 18;
            this.labelMotorStatus.Text = "NC";
            this.labelMotorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Yellow;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(65, 11);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 34);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.TabStop = false;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelPorts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(351, 427);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 19;
            // 
            // panelPorts
            // 
            this.panelPorts.Controls.Add(this.comboBoxPorts);
            this.panelPorts.Controls.Add(this.buttonPort);
            this.panelPorts.Controls.Add(this.buttonRefreshPorts);
            this.panelPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPorts.Location = new System.Drawing.Point(0, 0);
            this.panelPorts.Name = "panelPorts";
            this.panelPorts.Size = new System.Drawing.Size(351, 75);
            this.panelPorts.TabIndex = 20;
            this.panelPorts.TabStop = false;
            this.panelPorts.Text = "Serial Port";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelStepperInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(351, 348);
            this.splitContainer2.SplitterDistance = 76;
            this.splitContainer2.TabIndex = 0;
            // 
            // panelStepperInfo
            // 
            this.panelStepperInfo.Controls.Add(this.textBoxInfo3);
            this.panelStepperInfo.Controls.Add(this.label3);
            this.panelStepperInfo.Controls.Add(this.label10);
            this.panelStepperInfo.Controls.Add(this.textBoxInfo1);
            this.panelStepperInfo.Controls.Add(this.label9);
            this.panelStepperInfo.Controls.Add(this.textBoxInfo2);
            this.panelStepperInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStepperInfo.Location = new System.Drawing.Point(0, 0);
            this.panelStepperInfo.Name = "panelStepperInfo";
            this.panelStepperInfo.Size = new System.Drawing.Size(351, 76);
            this.panelStepperInfo.TabIndex = 20;
            this.panelStepperInfo.TabStop = false;
            this.panelStepperInfo.Text = "Motion Settings";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panelControl);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonExit);
            this.splitContainer3.Panel2.Controls.Add(this.buttonStop);
            this.splitContainer3.Panel2.Controls.Add(this.labelMotorStatus);
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Size = new System.Drawing.Size(351, 268);
            this.splitContainer3.SplitterDistance = 176;
            this.splitContainer3.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl.Controls.Add(this.numericUpDown1);
            this.panelControl.Controls.Add(this.buttonSetPos);
            this.panelControl.Controls.Add(this.label12);
            this.panelControl.Controls.Add(this.label7);
            this.panelControl.Controls.Add(this.buttonInchRight);
            this.panelControl.Controls.Add(this.textBoxInfo4);
            this.panelControl.Controls.Add(this.buttonInchLeft);
            this.panelControl.Controls.Add(this.label8);
            this.panelControl.Controls.Add(this.label11);
            this.panelControl.Controls.Add(this.buttonMove);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(351, 176);
            this.panelControl.TabIndex = 20;
            this.panelControl.TabStop = false;
            this.panelControl.Text = "Stepper Motor Control";
            // 
            // StepperApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(351, 427);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 505);
            this.Name = "StepperApp";
            this.Text = "StepperTestApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelPorts.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelStepperInfo.ResumeLayout(false);
            this.panelStepperInfo.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonRefreshPorts;
        private System.Windows.Forms.Button buttonPort;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxInfo3;
        private System.Windows.Forms.TextBox textBoxInfo2;
        private System.Windows.Forms.TextBox textBoxInfo1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonInchRight;
        private System.Windows.Forms.Button buttonInchLeft;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxInfo4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSetPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMotorStatus;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox panelPorts;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox panelStepperInfo;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox panelControl;
    }
}

