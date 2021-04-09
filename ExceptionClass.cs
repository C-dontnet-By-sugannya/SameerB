using System;

using System.IO;

namespace ExceptionHelperClass
{
    public class ExceptionClass : Exception
    {
        public const string filePath = @"C:\Users\user\source\repos\BankCustomer\ExceptionHelperClass\bin\Exception.txt";

        public ExceptionClass(string message)
        {
            Console.WriteLine("User defined Execption");
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
