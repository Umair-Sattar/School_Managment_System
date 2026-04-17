using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Managment_System
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person()
        {
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name:\t{Name}");
            Console.WriteLine($"Age:\t{Age}");
        }
    }
}