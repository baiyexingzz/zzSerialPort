namespace zzSerialPortTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_stop = new System.Windows.Forms.ComboBox();
            this.button_openPort = new System.Windows.Forms.Button();
            this.label_portState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_flow = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_rcvData = new System.Windows.Forms.ListBox();
            this.button_clrRcvData = new System.Windows.Forms.Button();
            this.button_saveData = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_savedSend = new System.Windows.Forms.ComboBox();
            this.button_clrSendData = new System.Windows.Forms.Button();
            this.button_sendData = new System.Windows.Forms.Button();
            this.richTextBox_sendData = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_showTime = new System.Windows.Forms.CheckBox();
            this.checkBox_showSending = new System.Windows.Forms.CheckBox();
            this.radioButton_rcvHex = new System.Windows.Forms.RadioButton();
            this.radioButton_rcvAsc = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_AutoSendInterval = new System.Windows.Forms.NumericUpDown();
            this.checkBox_AutoSend = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton_sendHex = new System.Windows.Forms.RadioButton();
            this.radioButton_sendAsc = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AutoSendInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // comboBox_port
            // 
            this.comboBox_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(65, 20);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(76, 20);
            this.comboBox_port.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate";
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.DisplayMember = "9600";
            this.comboBox_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(65, 46);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(76, 20);
            this.comboBox_baudrate.TabIndex = 3;
            this.comboBox_baudrate.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // comboBox_data
            // 
            this.comboBox_data.DisplayMember = "8";
            this.comboBox_data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_data.Location = new System.Drawing.Point(65, 72);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(76, 20);
            this.comboBox_data.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parity";
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.comboBox_parity.Location = new System.Drawing.Point(65, 98);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(76, 20);
            this.comboBox_parity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop";
            // 
            // comboBox_stop
            // 
            this.comboBox_stop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stop.FormattingEnabled = true;
            this.comboBox_stop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox_stop.Location = new System.Drawing.Point(65, 124);
            this.comboBox_stop.Name = "comboBox_stop";
            this.comboBox_stop.Size = new System.Drawing.Size(76, 20);
            this.comboBox_stop.TabIndex = 9;
            // 
            // button_openPort
            // 
            this.button_openPort.Location = new System.Drawing.Point(66, 194);
            this.button_openPort.Name = "button_openPort";
            this.button_openPort.Size = new System.Drawing.Size(75, 23);
            this.button_openPort.TabIndex = 10;
            this.button_openPort.Text = "Open";
            this.button_openPort.UseVisualStyleBackColor = true;
            this.button_openPort.Click += new System.EventHandler(this.button_openPort_Click);
            // 
            // label_portState
            // 
            this.label_portState.AutoSize = true;
            this.label_portState.ForeColor = System.Drawing.Color.Red;
            this.label_portState.Location = new System.Drawing.Point(6, 199);
            this.label_portState.Name = "label_portState";
            this.label_portState.Size = new System.Drawing.Size(53, 12);
            this.label_portState.TabIndex = 11;
            this.label_portState.Text = "is Close";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_flow);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox_port);
            this.groupBox1.Controls.Add(this.label_portState);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_openPort);
            this.groupBox1.Controls.Add(this.comboBox_baudrate);
            this.groupBox1.Controls.Add(this.comboBox_data);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_stop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_parity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 223);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // comboBox_flow
            // 
            this.comboBox_flow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_flow.FormattingEnabled = true;
            this.comboBox_flow.Items.AddRange(new object[] {
            "None",
            "XOnOff",
            "Hardware",
            "Last"});
            this.comboBox_flow.Location = new System.Drawing.Point(65, 150);
            this.comboBox_flow.Name = "comboBox_flow";
            this.comboBox_flow.Size = new System.Drawing.Size(76, 20);
            this.comboBox_flow.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Flow";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_rcvData);
            this.groupBox2.Controls.Add(this.button_clrRcvData);
            this.groupBox2.Controls.Add(this.button_saveData);
            this.groupBox2.Location = new System.Drawing.Point(167, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 323);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive Data";
            // 
            // listBox_rcvData
            // 
            this.listBox_rcvData.FormattingEnabled = true;
            this.listBox_rcvData.ItemHeight = 12;
            this.listBox_rcvData.Location = new System.Drawing.Point(6, 20);
            this.listBox_rcvData.Name = "listBox_rcvData";
            this.listBox_rcvData.Size = new System.Drawing.Size(475, 268);
            this.listBox_rcvData.TabIndex = 16;
            // 
            // button_clrRcvData
            // 
            this.button_clrRcvData.Location = new System.Drawing.Point(406, 291);
            this.button_clrRcvData.Name = "button_clrRcvData";
            this.button_clrRcvData.Size = new System.Drawing.Size(75, 23);
            this.button_clrRcvData.TabIndex = 15;
            this.button_clrRcvData.Text = "Clear";
            this.button_clrRcvData.UseVisualStyleBackColor = true;
            this.button_clrRcvData.Click += new System.EventHandler(this.button_clrRcvData_Click);
            // 
            // button_saveData
            // 
            this.button_saveData.Location = new System.Drawing.Point(325, 291);
            this.button_saveData.Name = "button_saveData";
            this.button_saveData.Size = new System.Drawing.Size(75, 23);
            this.button_saveData.TabIndex = 14;
            this.button_saveData.Text = "Save";
            this.button_saveData.UseVisualStyleBackColor = true;
            this.button_saveData.Click += new System.EventHandler(this.button_saveData_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_savedSend);
            this.groupBox3.Controls.Add(this.button_clrSendData);
            this.groupBox3.Controls.Add(this.button_sendData);
            this.groupBox3.Controls.Add(this.richTextBox_sendData);
            this.groupBox3.Location = new System.Drawing.Point(167, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 135);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sending data";
            // 
            // comboBox_savedSend
            // 
            this.comboBox_savedSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_savedSend.FormattingEnabled = true;
            this.comboBox_savedSend.Location = new System.Drawing.Point(6, 108);
            this.comboBox_savedSend.Name = "comboBox_savedSend";
            this.comboBox_savedSend.Size = new System.Drawing.Size(394, 20);
            this.comboBox_savedSend.TabIndex = 17;
            // 
            // button_clrSendData
            // 
            this.button_clrSendData.Location = new System.Drawing.Point(406, 66);
            this.button_clrSendData.Name = "button_clrSendData";
            this.button_clrSendData.Size = new System.Drawing.Size(75, 23);
            this.button_clrSendData.TabIndex = 16;
            this.button_clrSendData.Text = "Clear";
            this.button_clrSendData.UseVisualStyleBackColor = true;
            this.button_clrSendData.Click += new System.EventHandler(this.button_clrSendData_Click);
            // 
            // button_sendData
            // 
            this.button_sendData.Location = new System.Drawing.Point(406, 106);
            this.button_sendData.Name = "button_sendData";
            this.button_sendData.Size = new System.Drawing.Size(75, 23);
            this.button_sendData.TabIndex = 15;
            this.button_sendData.Text = "Send";
            this.button_sendData.UseVisualStyleBackColor = true;
            this.button_sendData.Click += new System.EventHandler(this.button_sendData_Click);
            // 
            // richTextBox_sendData
            // 
            this.richTextBox_sendData.Location = new System.Drawing.Point(6, 20);
            this.richTextBox_sendData.Name = "richTextBox_sendData";
            this.richTextBox_sendData.Size = new System.Drawing.Size(394, 82);
            this.richTextBox_sendData.TabIndex = 0;
            this.richTextBox_sendData.Text = "";
            this.richTextBox_sendData.TextChanged += new System.EventHandler(this.richTextBox_sendData_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_showTime);
            this.groupBox4.Controls.Add(this.checkBox_showSending);
            this.groupBox4.Controls.Add(this.radioButton_rcvHex);
            this.groupBox4.Controls.Add(this.radioButton_rcvAsc);
            this.groupBox4.Location = new System.Drawing.Point(12, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 94);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive Settings";
            // 
            // checkBox_showTime
            // 
            this.checkBox_showTime.AutoSize = true;
            this.checkBox_showTime.Checked = true;
            this.checkBox_showTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showTime.Location = new System.Drawing.Point(9, 69);
            this.checkBox_showTime.Name = "checkBox_showTime";
            this.checkBox_showTime.Size = new System.Drawing.Size(78, 16);
            this.checkBox_showTime.TabIndex = 3;
            this.checkBox_showTime.Text = "Show time";
            this.checkBox_showTime.UseVisualStyleBackColor = true;
            this.checkBox_showTime.CheckedChanged += new System.EventHandler(this.checkBox_showTime_CheckedChanged);
            // 
            // checkBox_showSending
            // 
            this.checkBox_showSending.AutoSize = true;
            this.checkBox_showSending.Checked = true;
            this.checkBox_showSending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showSending.Location = new System.Drawing.Point(9, 47);
            this.checkBox_showSending.Name = "checkBox_showSending";
            this.checkBox_showSending.Size = new System.Drawing.Size(102, 16);
            this.checkBox_showSending.TabIndex = 2;
            this.checkBox_showSending.Text = "Show sendings";
            this.checkBox_showSending.UseVisualStyleBackColor = true;
            this.checkBox_showSending.CheckedChanged += new System.EventHandler(this.checkBox_showSending_CheckedChanged);
            // 
            // radioButton_rcvHex
            // 
            this.radioButton_rcvHex.AutoSize = true;
            this.radioButton_rcvHex.Checked = true;
            this.radioButton_rcvHex.Location = new System.Drawing.Point(74, 25);
            this.radioButton_rcvHex.Name = "radioButton_rcvHex";
            this.radioButton_rcvHex.Size = new System.Drawing.Size(41, 16);
            this.radioButton_rcvHex.TabIndex = 1;
            this.radioButton_rcvHex.TabStop = true;
            this.radioButton_rcvHex.Text = "hex";
            this.radioButton_rcvHex.UseVisualStyleBackColor = true;
            this.radioButton_rcvHex.CheckedChanged += new System.EventHandler(this.radioButton_Receive_CheckedChanged);
            // 
            // radioButton_rcvAsc
            // 
            this.radioButton_rcvAsc.AutoSize = true;
            this.radioButton_rcvAsc.Location = new System.Drawing.Point(9, 25);
            this.radioButton_rcvAsc.Name = "radioButton_rcvAsc";
            this.radioButton_rcvAsc.Size = new System.Drawing.Size(59, 16);
            this.radioButton_rcvAsc.TabIndex = 0;
            this.radioButton_rcvAsc.Text = "asc II";
            this.radioButton_rcvAsc.UseVisualStyleBackColor = true;
            this.radioButton_rcvAsc.CheckedChanged += new System.EventHandler(this.radioButton_Receive_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown_AutoSendInterval);
            this.groupBox5.Controls.Add(this.checkBox_AutoSend);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.radioButton_sendHex);
            this.groupBox5.Controls.Add(this.radioButton_sendAsc);
            this.groupBox5.Location = new System.Drawing.Point(12, 341);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(149, 89);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sending settings";
            // 
            // numericUpDown_AutoSendInterval
            // 
            this.numericUpDown_AutoSendInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_AutoSendInterval.Location = new System.Drawing.Point(62, 47);
            this.numericUpDown_AutoSendInterval.Maximum = new decimal(new int[] {
            9900,
            0,
            0,
            0});
            this.numericUpDown_AutoSendInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_AutoSendInterval.Name = "numericUpDown_AutoSendInterval";
            this.numericUpDown_AutoSendInterval.Size = new System.Drawing.Size(49, 21);
            this.numericUpDown_AutoSendInterval.TabIndex = 17;
            this.numericUpDown_AutoSendInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // checkBox_AutoSend
            // 
            this.checkBox_AutoSend.AutoSize = true;
            this.checkBox_AutoSend.Location = new System.Drawing.Point(8, 48);
            this.checkBox_AutoSend.Name = "checkBox_AutoSend";
            this.checkBox_AutoSend.Size = new System.Drawing.Size(48, 16);
            this.checkBox_AutoSend.TabIndex = 16;
            this.checkBox_AutoSend.Text = "Auto";
            this.checkBox_AutoSend.UseVisualStyleBackColor = true;
            this.checkBox_AutoSend.CheckedChanged += new System.EventHandler(this.checkBox_AutoSend_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "ms";
            // 
            // radioButton_sendHex
            // 
            this.radioButton_sendHex.AutoSize = true;
            this.radioButton_sendHex.Checked = true;
            this.radioButton_sendHex.Location = new System.Drawing.Point(74, 20);
            this.radioButton_sendHex.Name = "radioButton_sendHex";
            this.radioButton_sendHex.Size = new System.Drawing.Size(41, 16);
            this.radioButton_sendHex.TabIndex = 3;
            this.radioButton_sendHex.TabStop = true;
            this.radioButton_sendHex.Text = "hex";
            this.radioButton_sendHex.UseVisualStyleBackColor = true;
            this.radioButton_sendHex.CheckedChanged += new System.EventHandler(this.radioButton_Send_CheckedChanged);
            // 
            // radioButton_sendAsc
            // 
            this.radioButton_sendAsc.AutoSize = true;
            this.radioButton_sendAsc.Location = new System.Drawing.Point(9, 20);
            this.radioButton_sendAsc.Name = "radioButton_sendAsc";
            this.radioButton_sendAsc.Size = new System.Drawing.Size(59, 16);
            this.radioButton_sendAsc.TabIndex = 2;
            this.radioButton_sendAsc.Text = "asc II";
            this.radioButton_sendAsc.UseVisualStyleBackColor = true;
            this.radioButton_sendAsc.CheckedChanged += new System.EventHandler(this.radioButton_Send_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 40);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "zz Serial Port Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AutoSendInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_stop;
        private System.Windows.Forms.Button button_openPort;
        private System.Windows.Forms.Label label_portState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_flow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_clrRcvData;
        private System.Windows.Forms.Button button_saveData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_clrSendData;
        private System.Windows.Forms.Button button_sendData;
        private System.Windows.Forms.RichTextBox richTextBox_sendData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_showTime;
        private System.Windows.Forms.CheckBox checkBox_showSending;
        private System.Windows.Forms.RadioButton radioButton_rcvHex;
        private System.Windows.Forms.RadioButton radioButton_rcvAsc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_sendHex;
        private System.Windows.Forms.RadioButton radioButton_sendAsc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox_rcvData;
        private System.Windows.Forms.NumericUpDown numericUpDown_AutoSendInterval;
        private System.Windows.Forms.CheckBox checkBox_AutoSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_savedSend;

    }
}

