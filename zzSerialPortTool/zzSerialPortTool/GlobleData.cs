using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzSerialPortTool
{
    class GlobleData
    {
    }
    public enum tUARTBaudRate
    {
        BaudRate_110 = 0,
        BaudRate_300,
        BaudRate_1200,
        BaudRate_2400,
        BaudRate_4800,
        BaudRate_9600,
        BaudRate_19200,
        BaudRate_38400,
        BaudRate_57600,
        BaudRate_115200,
        BaudRate_230400,
        BaudRate_460800,
        BaudRate_921600,
        BaudRate_Last,
    }

    public enum tUARTDataBits
    {
        DataBits_5 = 0,
        DataBits_6,
        DataBits_7,
        DataBits_8,
        DataBits_Last,
    }

    public enum tUARTParity
    {
        Parity_None= 0,
        Parity_Even,
        Parity_Odd,
        Parity_Mark,
        Parity_Space,
        Parity_Last,
    }

    public enum tUARTStopBit
    {
        StopBit_1 = 0,
        StopBit_1_5,
        StopBit_2,
        StopBit_Last,
    }

    public enum tUARTFlow
    {
        Flow_None = 0,
        Flow_XOnOff,
        Flow_Hardware,
        Flow_Last,
    }

    public class tUARTPortSettings
    {
        public tUARTPortSettings()
        {
            strPortNumber = "COM0";
            tBaudRate = tUARTBaudRate.BaudRate_9600;
            tDataBits = tUARTDataBits.DataBits_8;
            tParity = tUARTParity.Parity_Even;
            tStopBit = tUARTStopBit.StopBit_1;
            tFlowControl = tUARTFlow.Flow_None;
        }

        public tUARTPortSettings(tUARTPortSettings srcPort)
        {
            Duplicate(srcPort);
        }

        public string strPortNumber;
        public tUARTBaudRate tBaudRate;
        public tUARTDataBits tDataBits;
        public tUARTParity tParity;
        public tUARTStopBit tStopBit;
        public tUARTFlow tFlowControl;

        public void Duplicate(tUARTPortSettings srcPort)
        {
            strPortNumber = srcPort.strPortNumber;
            tBaudRate = srcPort.tBaudRate;
            tDataBits = srcPort.tDataBits;
            tParity = srcPort.tParity;
            tStopBit = srcPort.tStopBit;
            tFlowControl = srcPort.tFlowControl;
        }
    }
}
