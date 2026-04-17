using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Managment_System
{
    class Program
    {
        static void MainInterface(School school)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"=====\tWelcome to {school.Name} System\t======");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1.Display total persons currently present in school.");
            Console.WriteLine("2.Display details of all persons in school");
            Console.WriteLine("3.Add a new person to school database");
            Console.WriteLine("4.Search a Person in School by Name");
            Console.WriteLine("5.Exit From the System");
            Console.Write("\nEnter your choice:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    school.TotalPerson();
                    Console.WriteLine("\nPress any key to return to Main-Interface");
                    Console.ReadKey();
                    MainInterface(school);
                    break;
                case 2:
                    school.DisplayDetails();
                    Console.WriteLine("\nPress any key to return to Main-Interface");
                    Console.ReadKey();
                    MainInterface(school);
                    break;
                case 3:
                    AddMembers(school);
                    break;
                case 4:
                    school.SearchByName();
                    Console.WriteLine("\nPress any key to return to Main-Interface");
                    Console.ReadKey();
                    MainInterface(school);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!!!");
                    Console.WriteLine("\nPress any key to return to Main-Interface");
                    Console.ReadKey();
                    MainInterface(school);
                    break;
            }
        }
        static void AddMembers(School s)
        {
            bool flag = false;
            do
            {
                Console.Write("Do you want to add record of another person in school records?\n Y==> Yes N==> No\t");
                string x = Console.ReadLine();
                if (x.ToLower() == "y")
                {
                    flag = true;
                    Console.WriteLine("Addition of a Person to School Records");
                    Console.Write("Name of Person:");
                    string name = Console.ReadLine();
                    Console.Write("Age of Person:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n A bit more details required...");
                    Console.WriteLine($"What type of Person is {name}?");
                    Console.WriteLine("1.Teacher\n2.Staff\n3.Student");
                    Console.Write("Enter your choice:");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.Write("Subject of Teacher:");
                            string subject = Console.ReadLine();
                            Teacher t1 = new Teacher(name, age, subject);
                            s.AddMember(t1);
                            break;
                        case 2:
                            Console.Write("Role of Staff:");
                            string role = Console.ReadLine();
                            Staff stf1 = new Staff(name, age, role);
                            s.AddMember(stf1);
                            break;
                        case 3:
                            Console.Write($"Degree of {name}:");
                            string degree = Console.ReadLine();
                            Console.Write($"Grade of {name}");
                            string grade = Console.ReadLine();
                            Student s1 = new Student(name, age, grade, degree);
                            s.AddMember(s1);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice.Try adding person with appropriate person type.");
                            Console.ReadKey();
                            AddMembers(s);
                            break;
                    }
                }
                else
                {
                    flag = false;
                    Console.Write("Press any key to return to Main-Interface:");
                    Console.ReadKey();
                    MainInterface(s);
                }
            } while (flag == true);
        }
            static void Main(string[] args)
        {
            School s = new School("Al-Falah School");
            MainInterface(s);
            Console.ReadKey();
        }
    }
}
