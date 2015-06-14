using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;//regular expressions
using System.Collections;//arraylist
using System.IO.Ports;//serial ports class
using System.Threading;
using System.Timers;

namespace zzSerialPortTool
{
    public partial class Form1 : Form
    {
        private static Form1 _instance; 
        public Form1()
        {
            _instance = this;
            InitializeComponent();
        }
        public static Form1 getInstance() { return _instance; }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_baudrate.SelectedIndex = 5;
            comboBox_data.SelectedIndex = 3;
            comboBox_flow.SelectedIndex = 0;
            comboBox_parity.SelectedIndex = 0;
            comboBox_stop.SelectedIndex = 0;

            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            
            comboBox_port.Items.AddRange(ports);
            comboBox_port.SelectedIndex = comboBox_port.Items.Count > 0 ? 0 : -1;

            System.Timers.Timer SerialPortDetectTimer = new System.Timers.Timer(1000);
            SerialPortDetectTimer.AutoReset = true;
            SerialPortDetectTimer.Elapsed += SerialPortDetect;
            SerialPortDetectTimer.Enabled = true;

        }
        #region Variables
        HAL_port Hal_port = new HAL_port();
        Util_FileStream FileStream_SaveTxt = new Util_FileStream();
        List<byte> cmdArrayList = new List<byte>();
        private SerialPort serialPort = new SerialPort();
        bool isRcvInHex = true;
        bool isSendInHex = true;
        bool canShowTime = true;
        bool canShowSendings = true;
        private Encoding encoding = Encoding.ASCII;
        byte[] returnStr;
        #endregion

        #region Event Handler
        public void port_DataReceived(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            returnStr = Hal_port.ReadAvailable();
            //GetReturnMsg(returnStr);
            this.Invoke(new System.EventHandler(GetReturnMsg));
            
        }
        private void SerialPortDetect(object sender, EventArgs e)
        {
            if (Hal_port.GetPortStatus() == false)
            {

                this.Invoke(new System.EventHandler(ShowAvailiblePort));
               
            }
            
        }
        private void ShowAvailiblePort(object sender, System.EventArgs e)
        {
            comboBox_port.Items.Clear();
            string[] portsAvalible = SerialPort.GetPortNames();
            Array.Sort(portsAvalible);
            comboBox_port.Items.AddRange(portsAvalible);
            comboBox_port.SelectedIndex = comboBox_port.Items.Count > 0 ? 0 : -1;
        }
       
        private void button_openPort_Click(object sender, EventArgs e)
        {
            if (Hal_port.GetPortStatus() == true)
                return;
            tUARTPortSettings portSettings = new tUARTPortSettings();

            if ("" == Convert.ToString(comboBox_port.Text))
            {
                MessageBox.Show("No port available！");
                return;
            }

            portSettings.strPortNumber = Convert.ToString(comboBox_port.Text);
            portSettings.tBaudRate = (tUARTBaudRate)(comboBox_baudrate.SelectedIndex);
            portSettings.tDataBits = (tUARTDataBits)(comboBox_data.SelectedIndex);
            portSettings.tFlowControl = (tUARTFlow)(comboBox_flow.SelectedIndex);
            portSettings.tStopBit = (tUARTStopBit)(comboBox_stop.SelectedIndex);
            portSettings.tParity = (tUARTParity)(comboBox_parity.SelectedIndex);

            if (false == Hal_port.OpenPort(portSettings))
            {
                MessageBox.Show("Failed to open this port！");
                return;
            }

            label_portState.Text = "is Open";
            label_portState.ForeColor = Color.Green;

        }

        private void button_saveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:\\Patch";
            saveFileDialog1.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter tmpStreamWriter = null;
                    if (!File.Exists(saveFileDialog1.FileName))
                    {
                        //if not exist, create a new file
                        tmpStreamWriter = File.CreateText(saveFileDialog1.FileName);
                        if (false == FileStream_SaveTxt.CloseWriter(tmpStreamWriter))
                        {
                            throw (new Exception("Fail to close file"));
                        }
                    }

                    if (false == FileStream_SaveTxt.OpenWriter(saveFileDialog1.FileName, ref tmpStreamWriter))
                    {
                        throw (new Exception("Fail to open file"));
                    }

                    DateTime currentTime = System.DateTime.Now; 
                    tmpStreamWriter.WriteLine("Serial Port Messages:");
                    foreach (string itemText in listBox_rcvData.Items)
                    {
                        tmpStreamWriter.WriteLine(itemText);
                    }

                    if (false == FileStream_SaveTxt.CloseWriter(tmpStreamWriter))
                    {
                        throw (new Exception("Fail to close file"));
                    }
                }
                catch
                {
                    MessageBox.Show("Error!");
                    return;
                }
                MessageBox.Show("Data has been saved!");
            }
        }
        private void button_clrRcvData_Click(object sender, EventArgs e)
        {
            listBox_rcvData.Items.Clear();
        }

        private void button_clrSendData_Click(object sender, EventArgs e)
        {
            richTextBox_sendData.Clear();
        }
       

        private void button_sendData_Click(object sender, EventArgs e)
        {
            if (Hal_port.GetPortStatus() == false)
                return;
            try
            {

                String hexString = richTextBox_sendData.Text.ToString();
                if (isSendInHex == true)
                {
                    cmdArrayList.Clear();
                    hexString = hexString.Replace(" ", "");
                    if (hexString == "")
                    {
                        //  MessageBox.Show("Textbox can not be empty!");
                        return;
                    }

                    for (int i = 0; i < (hexString.Length / 2); i++)
                        cmdArrayList.Add(Convert.ToByte(hexString.Substring(i * 2, 2), 16));
                    Hal_port.SendBuffer(cmdArrayList.ToArray());
                }
                else
                {
                    cmdArrayList.Clear();
                    byte[] tmp = encoding.GetBytes(hexString);
                    foreach (byte i in tmp)
                    {
                        cmdArrayList.Add(i);
                    }
                    Hal_port.SendBuffer(tmp);
                }
               
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void richTextBox_sendData_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox_sendData.SelectionStart == richTextBox_sendData.Text.Length&&isSendInHex==true)
            {
                String input = richTextBox_sendData.Text.ToString();

                string r = Regex.Replace(input, @"(?<=[0-9A-Fa-f]{2})[0-9A-Fa-f]{2}", " $0");

                richTextBox_sendData.Text = r;
                richTextBox_sendData.SelectionStart = richTextBox_sendData.Text.Length;
            }
        }

        private void radioButton_Receive_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_rcvHex.Checked == true && radioButton_rcvAsc.Checked == false)
            {
                isRcvInHex = true;
            }
            if (radioButton_rcvHex.Checked == false && radioButton_rcvAsc.Checked == true)
            {
                isRcvInHex = false;
            }
        }
        private void radioButton_Send_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_sendHex.Checked == true && radioButton_sendAsc.Checked == false)
            {
                isSendInHex = true;
            }
            if (radioButton_sendHex.Checked == false && radioButton_sendAsc.Checked == true)
            {
                isSendInHex = false;
            }
        }

        private void checkBox_showSending_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showSending.Checked == true)
                canShowSendings = true;
            if (checkBox_showSending.Checked == false)
                canShowSendings = false;
        }

        private void checkBox_showTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showTime.Checked == true)
                canShowTime = true;
            if (checkBox_showTime.Checked == false)
                canShowTime = false;
        }
        private void AutoSendHandler(object sender, EventArgs e)
        {
            if (Hal_port.GetPortStatus() == true && cmdArrayList.Count > 0)
                Hal_port.SendBuffer(cmdArrayList.ToArray());

            if (checkBox_AutoSend.Checked == true)
            {
                int autoInterval = (int)numericUpDown_AutoSendInterval.Value;
                System.Timers.Timer AutoSendTimer = new System.Timers.Timer(autoInterval);
                AutoSendTimer.Enabled = true;
                AutoSendTimer.AutoReset = false;
                AutoSendTimer.Elapsed += AutoSendHandler;
            }
        }
        private void checkBox_AutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AutoSend.Checked == true)
            {
                int autoInterval = (int)numericUpDown_AutoSendInterval.Value;
                System.Timers.Timer AutoSendTimer = new System.Timers.Timer(autoInterval);
                AutoSendTimer.Enabled = true;
                AutoSendTimer.AutoReset = false;
                AutoSendTimer.Elapsed += AutoSendHandler;
            }

        }
        #endregion


        #region
        private void GetReturnMsg(object sender, EventArgs e/*byte[] returnStr*/)
        {
            string SendingMsg = "";
            string RetMsg = "";
            if (canShowSendings == true&&cmdArrayList.Count>0)
            {
                SendingMsg += "<< ";
                for (int i = 0; i < cmdArrayList.Count; i++)
                {
                    SendingMsg += cmdArrayList[i].ToString("X2");
                    SendingMsg += " ";
                }
                if (canShowTime == true)
                {
                    SendingMsg += DateTime.Now.ToString();
                }
                listBox_rcvData.Items.Add(SendingMsg);
            }
            if (returnStr.Length > 0)
            {
                RetMsg += ">> ";
                if (isRcvInHex == true)
                {
                    for (int i = 0; i < returnStr.Length; i++)
                    {
                        RetMsg += returnStr[i].ToString("X2");
                        RetMsg += " ";
                    }
                }
                else
                {
                    string str = encoding.GetString(returnStr);
                    RetMsg += str;
                    RetMsg += " ";
                }
                if (canShowTime == true)
                {
                    RetMsg += DateTime.Now.ToString();
                }
                listBox_rcvData.Items.Add(RetMsg);
                listBox_rcvData.SetSelected(listBox_rcvData.Items.Count - 1, true);
                listBox_rcvData.Refresh();
            }
        }

        private void AddSendingMsgToXml(string str)
        {

        }
       

        #endregion

    }
}
