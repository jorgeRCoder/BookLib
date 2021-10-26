using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookLib
{
    class Log
    {
        private static string _logFileName;

        public Log()
        {
            _logFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "myLog.txt");
            //put in message box path
        }

        public static void ErorrLog(string logMessage)
        {
            File.AppendAllText(_logFileName, $"[{DateTime.Now}]\t[{logMessage}]\n");
        }
    }
}
