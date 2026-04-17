using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_Managment_System
{
    public class School
    {
        public string Name { get; }
        public List<Person> Members = new List<Person>();
        public School(string name)
        {
            this.Name = name;
        }

        public Person Person
        {
            get => default(Person);
            set
            {
            }
        }
        public void AddMember(Person person)
        {
            Members.Add(person);
            Console.WriteLine("Addition of a Person to School's Records...");
            Console.WriteLine($"Person {person.Name} successfully added to school database");
            Console.WriteLine("-------------------------");
        }

        public void DisplayDetails()
        {
            if (Members.Count() == 0)
            {
                Console.WriteLine("Currently no person is regisered in school database.");
            }
            else
            {
                for (int i = 0; i < Members.Count(); i++)
                {
                    if (Members[i].GetType() == typeof(Student))
                    {
                        Members[i].DisplayDetails();
                        Console.WriteLine("-------------------------");
                    }
                    if (Members[i].GetType() == typeof(Teacher))
                    {
                        Members[i].DisplayDetails();
                        Console.WriteLine("-------------------------");
                    }
                    if (Members[i].GetType() == typeof(Staff))
                    {
                        Members[i].DisplayDetails();
                        Console.WriteLine("-------------------------");
                    }
                }
            }
        }

        public void SearchByName()
        {
            string name;
            Console.Write("Enter name of Person:");
            name = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < Members.Count(); i++)
            {
                if (name.ToLower() == Members[i].Name.ToLower())
                {
                    Members[i].DisplayDetails();
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Person with this name not found");
            }
        }
        public void TotalPerson()
        {
            int stud = 0;
            int teach = 0;
            int staff = 0;
            for (int i = 0; i < Members.Count(); i++)
            {
                if (Members[i] is Student)
                {
                    stud++;
                }
                if (Members[i] is Teacher)
                {
                    teach++;
                }
                if (Members[i] is Staff)
                {
                    staff++;
                }
            }
            Console.WriteLine($"Total Members in The School:{Members.Count()}");
            Console.WriteLine($"Total Teachers in The School:{teach}");
            Console.WriteLine($"Total Staff in The School:{staff}");
            Console.WriteLine($"Total Students in The School:{stud}");
        }
    }
}