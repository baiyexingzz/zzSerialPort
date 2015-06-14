using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace zzSerialPortTool
{
    public class HAL_port
    {

       #region Variables
        private SerialPort port = null;
        //Form1 lulu = new Form1(1);
        
        #endregion

        #region Private Interfaces
        private int ConvertBaudrate(tUARTBaudRate tBaudRate)
        {
            int iBaudRate = 115200;

            switch (tBaudRate)
            {
                case tUARTBaudRate.BaudRate_110:
                    iBaudRate = 110;
                    break;
                case tUARTBaudRate.BaudRate_300:
                    iBaudRate = 300;
                    break;
                case tUARTBaudRate.BaudRate_1200:
                    iBaudRate = 1200;
                    break;
                case tUARTBaudRate.BaudRate_2400:
                    iBaudRate = 2400;
                    break;
                case tUARTBaudRate.BaudRate_4800:
                    iBaudRate = 4800;
                    break;
                case tUARTBaudRate.BaudRate_9600:
                    iBaudRate = 9600;
                    break;
                case tUARTBaudRate.BaudRate_19200:
                    iBaudRate = 19200;
                    break;
                case tUARTBaudRate.BaudRate_38400:
                    iBaudRate = 38400;
                    break;
                case tUARTBaudRate.BaudRate_57600:
                    iBaudRate = 57600;
                    break;
                case tUARTBaudRate.BaudRate_115200:
                    iBaudRate = 115200;
                    break;
                case tUARTBaudRate.BaudRate_230400:
                    iBaudRate = 230400;
                    break;
                case tUARTBaudRate.BaudRate_460800:
                    iBaudRate = 460800;
                    break;
                case tUARTBaudRate.BaudRate_921600:
                    iBaudRate = 921600;
                    break;
            }

            return iBaudRate;
        }

        private int ConvertDataBits(tUARTDataBits tDataBits)
        {
            int iDataBits = 8;

            switch (tDataBits)
            {
                case tUARTDataBits.DataBits_5:
                    iDataBits = 5;
                    break;
                case tUARTDataBits.DataBits_6:
                    iDataBits = 6;
                    break;
                case tUARTDataBits.DataBits_7:
                    iDataBits = 7;
                    break;
                case tUARTDataBits.DataBits_8:
                    iDataBits = 8;
                    break;
            }

            return iDataBits;
        }

        private StopBits ConvertStopBit(tUARTStopBit tStopBit)
        {
            StopBits tLocalStopBit = StopBits.None;

            switch (tStopBit)
            {
                case tUARTStopBit.StopBit_1:
                    tLocalStopBit = StopBits.One;
                    break;
                case tUARTStopBit.StopBit_1_5:
                    tLocalStopBit = StopBits.OnePointFive;
                    break;
                case tUARTStopBit.StopBit_2:
                    tLocalStopBit = StopBits.Two;
                    break;
            }

            return tLocalStopBit;
        }

        private Parity ConvertPrity(tUARTParity tParity)
        {
            Parity tLocalParity = Parity.None;

            switch (tParity)
            {
                case tUARTParity.Parity_Mark:
                    tLocalParity = Parity.Mark;
                    break;
                case tUARTParity.Parity_None:
                    tLocalParity = Parity.None;
                    break;
                case tUARTParity.Parity_Odd:
                    tLocalParity = Parity.Odd;
                    break;
                case tUARTParity.Parity_Even:
                    tLocalParity = Parity.Even;
                    break;
                case tUARTParity.Parity_Space:
                    tLocalParity = Parity.Space;
                    break;
            }

            return tLocalParity;
        }
        #endregion

        #region Public Interfaces
        public bool OpenPort(tUARTPortSettings portSettings)
        {
            string portName = portSettings.strPortNumber;
            int baudRate = ConvertBaudrate(portSettings.tBaudRate); ;
            int dataBits = ConvertDataBits(portSettings.tDataBits);
            StopBits stopBits = ConvertStopBit(portSettings.tStopBit);
            Parity parity = ConvertPrity(portSettings.tParity);
            try
            {
                port = new SerialPort(portName, baudRate, parity, dataBits, stopBits);

                port.Open();
                
                port.DataReceived += Form1.getInstance().port_DataReceived;
                Clear();
                Thread.Sleep(5);
            }
            catch (Exception e)
            {
                throw e;
            }

            return port.IsOpen;
        }

        public void ClosePort()
        {
            try
            {
                if (port == null || port.IsOpen == false)
                {
                    return;
                }

                Thread.Sleep(5);
                port.Close();
                port = null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SendBuffer(byte[] buffer)
        {
            byte[] buffertemp = buffer;
            if (port == null || port.IsOpen == false)
                return;

            port.Write(buffertemp, 0, buffertemp.Length);
        }

        public void SetReadTimeout(int rdTimeout)
        {
            if (port == null || port.IsOpen == false)
            {
                return;
            }

            port.ReadTimeout = rdTimeout;
        }

        public byte[] ReadAvailable()
        {
            if (port == null || port.IsOpen == false)
            {
                return null;
            }

            byte[] buffer = new byte[port.BytesToRead];
            port.Read(buffer, 0, buffer.Length);

            return buffer;
        }

        public void Clear()
        {
            if (port == null || port.IsOpen == false)
                return;

            port.DiscardOutBuffer();
            port.DiscardInBuffer();
        }
        public bool GetPortStatus()
        {
            if (port == null)
                return false;
            else
                return port.IsOpen;
        }
        
        #endregion
    }

}
