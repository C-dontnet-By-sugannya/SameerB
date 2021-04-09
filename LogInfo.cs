using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StandAloneApplicationDemo
{
    public class LogInfo
    {
        public const string filePath = @"E:\CsharpTraining\StudentApp\LoggingHelper\bin\Log.txt";
        public static void writeLogFile(string message)
        {

            if (!File.Exists(filePath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(message + DateTime.UtcNow);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(message + DateTime.UtcNow);
                }
            }
        }
    }
}
