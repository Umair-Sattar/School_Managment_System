using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Managment_System
{
    public class Staff : Person
    {
        private string roleInOganization;

        public Staff(string name, int age, string role) : base(name, age)
        {
            this.roleInOganization = role;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Role In Org:{roleInOganization}");
        }
    }
}