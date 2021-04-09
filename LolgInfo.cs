using System;
using System.IO;
namespace LogFile
{
    public class LogInfo
    {

        public const string filePath = @"C:\Users\user\source\repos\BankCustomer\LogFile\bin\Log.txt";
        public static void writeLogFile(string message)
        {



            if (!File.Exists(filePath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(message + DateTime.Now);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(message + DateTime.Now);
                }
            }
        }
    }
}
