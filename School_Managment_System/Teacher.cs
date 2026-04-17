using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Managment_System
{
    public class Teacher : Person
    {
        private string subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Name of Subject:{subject}");
        }
    }
}