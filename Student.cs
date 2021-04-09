using System;
using System.Collections.Generic;
using System.Text;

namespace StandAloneApplicationDemo
{
    public class Student : College
    {
        /*2.Student Details - Netra
        Name
        class
        M1
        M2
        M3
        cgpa - private
        calcualateCGPA - calculates the CGPA (M1+M2+M2/3)
        Display Details - should display all the details*/

        public string name;
        public string classOfStudent;
        public int marks1;
        public int marks2;
        public int marks3;
        public const int totalSubjects = 3;
        private int cgpa;

        public void studentInfo()
        {
            Console.WriteLine("Enter the student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the student class:");
            classOfStudent = Console.ReadLine();
            Console.WriteLine("Enter 3 subjects marks:");
            marks1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the subject2 marks:");
            marks2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter the subject3 marks:");
            marks3 = Convert.ToInt32(Console.ReadLine());

        }
        public void calcualateCGPA()
        {
            cgpa = (marks1 + marks2 + marks3) / totalSubjects;
            Console.WriteLine("CGPA of " + name + ":" + cgpa);
        }
        public int CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public void displayInfo()
        {

            Console.WriteLine("Student name is:" + name);
            Console.WriteLine("Student class is:" + classOfStudent);
            Console.WriteLine("Marks of student is:" + marks1 + " " + marks2 + " " + " " + marks3);
        }


    }
}
