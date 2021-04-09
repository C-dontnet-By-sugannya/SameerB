using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StandAloneApplicationDemo
{
    public class MyApplicationHelper : Exception
    {
        public const string filePath = @"E:\CsharpTraining\StudentApp\ExceptionHelper\bin\Exception.txt";

        public MyApplicationHelper(string message)
        {
            Console.WriteLine("User defined Exaception");
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
