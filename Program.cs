using System;
using StandAloneApplicationDemo.Data;
using ExceptionHelper;
using LoggingHelper;


namespace StandAloneApplicationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                LoggingHelper.LogInfo.writeLogFile("Program has started");
                //create an array of student object   
                Student[] details = new Student[3];
                //create actual student objects using constructor  
                details[0] = new Student();
                details[1] = new Student();
                details[2] = new Student();

                //display the student object data  
                //details[0].displayInfo();
                //details[1].displayInfo();
                //details[2].displayInfo();
                //details[0].displayCGPA();
                //details[1].displayCGPA();
                //details[2].displayCGPA();

                //display the student object data  
                for (int i = 0; i < details.Length; i++)
                {
                    details[i].studentInfo();
                    details[i].collegeDetails();
                }
                for (int i = 0; i < details.Length; i++)
                {
                    details[i].displayInfo();
                    details[i].displayCollegeDetails();
                    details[i].calcualateCGPA();
                }
                Console.ReadLine();
            }
            catch (NullReferenceException Ex)
            {
                throw new MyApplicationHelper(Ex.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"{Ex.Message} at {Ex.StackTrace}");
            }
            Console.ReadLine();
        }

    }
}
