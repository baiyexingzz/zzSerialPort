using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace zzSerialPortTool
{
    class Util_FileStream
    {
        
        #region Public Interfaces
        public static long FileLength(string fileName)
        {
            if ((true == string.IsNullOrEmpty(fileName)) || (false == File.Exists(fileName)))
            {
                return 0;
            }

            FileInfo tmpInfo = new FileInfo(fileName);
            return tmpInfo.Length;
        }

        public static bool OpenReader(string fileName, ref StreamReader fileReader)
        {
            if (true == string.IsNullOrEmpty(fileName))
            {
                return false;
            }

            try
            {
                fileReader = new StreamReader(fileName);
            }
            catch 
            {
             
                return false;
            }

            return true;
        }

        public static bool CloseReader(StreamReader fileReader)
        {
            if (null == fileReader)
            {
                return false;
            }

            try
            {
                fileReader.Close();
            }
            catch 
            {
                
                return false;
            }

            return true;
        }

        public bool OpenWriter(string fileName, ref StreamWriter fileWriter)
        {
            if (true == string.IsNullOrEmpty(fileName))
            {
                return false;
            }

            try
            {
                fileWriter = new StreamWriter(fileName);
            }
            catch 
            {
               
                return false;
            }

            return true;
        }

        public bool CloseWriter(StreamWriter fileWriter)
        {
            if (null == fileWriter)
            {
                return false;
            }

            try
            {
                fileWriter.Close();
            }
            catch 
            {
               
                return false;
            }

            return true;
        }

        public static bool OpenXML(string fileName, ref XElement xmlLoader)
        {
            if (true == string.IsNullOrEmpty(fileName))
            {
                return false;
            }

            try
            {
                xmlLoader = XElement.Load(fileName);

                if ((xmlLoader == null) || (true == xmlLoader.IsEmpty))
                {
                    return false;
                }
            }
            catch 
            {
               
                return false;
            }

            return true;
        }

        public bool WriteStringList(string dstFile, string[] dstList)
        {
            StreamWriter tWriter = null;
            if (false == OpenWriter(dstFile, ref tWriter))
            {
                return false;
            }

            foreach (string l in dstList)
            {
                tWriter.WriteLine(l);
            }

            tWriter.Close();

            return true;
        }

        public bool WriteFile(string dstFile, string dstStr)
        {
            StreamWriter tWriter = null;
            if (false == OpenWriter(dstFile, ref tWriter))
            {
                return false;
            }

            tWriter.Write(dstStr);

            tWriter.Close();

            return true;
        }

        public static bool ReadString(string srcFile, ref string srcStr)
        {
            StreamReader tReader = null;
            if (false == OpenReader(srcFile, ref tReader))
            {
                return false;
            }

            srcStr = tReader.ReadToEnd();

            tReader.Close();

            return true;
        }
        #endregion
    }

}
