using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Students
{
    internal class Student
    {

        private int Age;
        public int age
        {
            get {  return Age; }
            set 
            { 
                if (value > 5)
                {
                   Age = value ;
                }else
                {
                    Console.WriteLine("Enter age greater than 5");
                }
            }
        }

        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private int Grade;
        public int grade
        {
            get { return Grade; }
            set
            {
                if (value >=0 && value <=100)
                {
                    Grade = value;

                }else
                {
                    Console.WriteLine("grade must be between 0 to 100 ");
                }
            }
        }
        public Student(  string name ,int age , int grade )
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name {Name} , Age {Age} , Grade {Grade} ");
        }

    }
}
