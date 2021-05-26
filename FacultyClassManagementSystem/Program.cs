using System;
using System.Collections.Generic;

namespace FacultyClassManagementSystem
{
    class Program
    {
        static void DisplayElements()
        {
            Console.WriteLine("\n\n\t\t\t\t\t\t------------------Faculty Class Management System------------------\n\n\t\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t\t\tWELCOME TO THE FACULTY CLASS MANAGEMENT SYSTEM!\n\n");
            Console.WriteLine("\t\t\t\t\t\tTeaching is more than imparting knowlege, it is inspiring to change.\n\n" +
                              "\t\t\t\t\t\tLearning is more than absorbing facts, it is acquiring understanding\n\n" +
                              "\t\t\t\t\t\t\t\t\t\t\t\t-William Arthur Ward\n\n");
        }
        static void Main(string[] args)
        {
            DisplayElements();
            DateandTime();

            string name = "\nJohn Mhark Ren\n";
            string name1 = "\nJohn Edward Gonzales\n";
            string name2 = "\nZaldy Manigbas\n";
            string age = "\n29 years old\n";
            string age1 = "\n32 years old\n";
            string age2 = "\n34 years old\n";
            string address = "\n#44 Candelaria St. Calatagan, Batangas\n";
            string address1 = "\nLot 4 Bldg. 13 Mariano St. Catanuan, Laguna\n";
            string address2 = "\n#112 Jose St. Hera Apartment TUY, Batangas\n";
            string subjectHadle = "\nMath\nScience\nEthics\n";
            string subjectHadle1 = "\nPhysics\nBiology\n";
            string subjectHadle2 = "\nP.E\nCalculus\n";
            string position = "\nFull Time Employee\n";
            string position1 = "\nFull Time Employee\n";
            string position2 = "\nPart Time Employee\n";
            string schedule = "\nMonday\nTuesday\nWednesday\nThursday\nFriday\n";
            string schedule1 = "\nTuesday\nWednesday\nFriday\nSaturday\n";
            string schedule2 = "\nMonday\nWednesday\nThursday\nSaturday\n";

            String user = "USERNAME";
            String pw = "123";
            String uinput, pwinput;
            int attempts = 0;
            do
            {
                Console.WriteLine("\n\nUSE ONLY CAPITAL LETTERS");
                Console.WriteLine("\nUsername: ");
                uinput = Console.ReadLine();

                Console.WriteLine("\nPassword: ");
                pwinput = Console.ReadLine();

                attempts++;
            } while (!uinput.Equals(user) && !pwinput.Equals(pw) && attempts != 2);
            if (uinput.Equals(user) && pwinput.Equals(pw))
            {
                Console.WriteLine("\nLog In Successfully");
            }
            else if (uinput.Equals(user))
            {
                do
                {
                    Console.WriteLine("\nInvalid password");
                    Console.WriteLine("correct pw: ");
                    pwinput = Console.ReadLine();

                    attempts++;
                } while (!pwinput.Equals(pw) && attempts != 2);
                if (pwinput.Equals(pw))
                {
                    Console.WriteLine("Log In Successfully");
                }
                else if (attempts == 2)
                {
                    Console.WriteLine("Log In INCORRECT");
                }
            }
            else if (pwinput.Equals(pw))
            {
                do
                {
                    Console.WriteLine("Invalid usernname");
                    Console.WriteLine("username: ");
                    uinput = Console.ReadLine();

                    attempts++;
                } while (!uinput.Equals(user) && attempts != 2);
                if (uinput.Equals(user))
                {
                    Console.WriteLine("Log in successfully");
                }
                else if (attempts == 2)
                {
                    Console.WriteLine("Log in INCORRECT");
                }
            }
            else if (attempts == 2)
            {
                Console.WriteLine("Log In Incorrect");
            }
            


            string login = Console.ReadLine();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t----------------------Teacher's List----------------------\n\n\n\t\t\t\t\t\t");

            Console.Write("\n\t\t\t\t1. John Mhark M. Ren");
            Console.Write("\n\t\t\t\t2. John Edward Gonzales");
            Console.Write("\n\t\t\t\t3. Zaly Manigbas");
            Console.Write("\n\n\nEnter the number of your choices:\n");
            char optionSelected1 = Console.ReadLine()[0];

            Console.WriteLine("\n\n\n\t\t\t\t\t\t---------------------------Result:------------------------\n\n\n\t\t\t\t\t\t");
            switch (optionSelected1)
            {
                case '1':
                    Console.WriteLine("Name:" + name);
                    name = Console.ReadLine();
                    Console.WriteLine("Age:" + age);
                    age = Console.ReadLine();
                    Console.WriteLine("Address:" + address);
                    address = Console.ReadLine();
                    Console.WriteLine("Subject Handle:" + subjectHadle);
                    subjectHadle = Console.ReadLine();
                    Console.WriteLine("Position:" + position);
                    position = Console.ReadLine();
                    Console.WriteLine("Schedule:" + schedule);
                    schedule = Console.ReadLine();
                    break;
                case '2':
                    Console.WriteLine("Name:" + name1);
                    name1 = Console.ReadLine();
                    Console.WriteLine("Age:" + age1);
                    age1 = Console.ReadLine();
                    Console.WriteLine("Address:" + address1);
                    address1 = Console.ReadLine();
                    Console.WriteLine("Subject Handle:" + subjectHadle1);
                    subjectHadle1 = Console.ReadLine();
                    Console.WriteLine("Position:" + position1);
                    position1 = Console.ReadLine();
                    Console.WriteLine("Schedule:" + schedule1);
                    schedule1 = Console.ReadLine();
                    break;
                case '3':
                    Console.WriteLine("Name:" + name2);
                    name2 = Console.ReadLine();
                    Console.WriteLine("Age:" + age2);
                    age2 = Console.ReadLine();
                    Console.WriteLine("Address:" + address2);
                    address2 = Console.ReadLine();
                    Console.WriteLine("Subject Handle:" + subjectHadle2);
                    subjectHadle2 = Console.ReadLine();
                    Console.WriteLine("Position:" + position2);
                    position2 = Console.ReadLine();
                    Console.WriteLine("Schedule:" + schedule2);
                    schedule2 = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine("\n\n\n\t\t\t\t\t\t---------------------------------------------------------------");
            Console.WriteLine("\n\t\tDo you want to view the Summary of Absent of all Faculty Member?");
            Console.WriteLine("\n\t\t01. Yes");
            Console.WriteLine("\n\t\t02. No");
            Console.Write("\n\nEnter the number of your choices: \n\n");
            char optionSelected2 = Console.ReadLine()[1];
            switch (optionSelected2)
            {
                case '1':
                    Console.WriteLine("\nYes");
                    Console.WriteLine("\n\t\t\t\t\t\t---------------------------------------------------------------");
                    List<Class1> clss1 = new List<Class1>();
                    clss1.Add(new Class1());
                    clss1[0].Name = "\nJohn Mhark M. Ren";
                    clss1[0].Absent = 3;
                    clss1.Add(new Class1());
                    clss1[1].Name = "\nJohn Edward Gonzales";
                    clss1[1].Absent = 1;
                    clss1.Add(new Class1());
                    clss1[2].Name = "\nZaly Manigbas";
                    clss1[2].Absent = 2;

                    foreach (Class1 class1 in clss1)
                    {
                        Console.WriteLine(class1.getData());
                    }
                    Console.ReadLine();
                    break;
                case '0':
                    Console.WriteLine("No");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            static void DateandTime()
            {
                Console.WriteLine("\nCurrent Date and Time: \n");
                DateTime dateTime = DateTime.Now;
                Console.WriteLine(dateTime.ToString());

                Console.ReadLine();
            }
        }
    }
}