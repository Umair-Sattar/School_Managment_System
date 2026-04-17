using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Managment_System
{
    public class Student : Person
    {

        private string grade;
        private string degree;

        public Student(string name, int age, string grade, string degree) : base(name, age)
        {
            this.grade = grade;
            this.degree = degree;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Grade:\t{grade}");
            Console.WriteLine($"Degree:\t{degree}");
        }
    }
}