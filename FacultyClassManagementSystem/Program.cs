using System;

namespace FacultyClassManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
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
            string schedule2 = "\nMonday\n\nWednesday\nThursday\nSaturday\n";

            Console.WriteLine("\n\n\n\t\t\t\t\t\t------------------Faculty Class Management System------------------\n\n\n\t\t\t\t\t\t");
            String user = "USERNAME";
            String pw = "PASSWORD";
            String uinput, pwinput;
            int attempts = 0;
            do
            {
                Console.WriteLine("USE ONLY CAPITAL LETTERS");
                Console.WriteLine("Username: ");
                uinput = Console.ReadLine();

                Console.WriteLine("Password: ");
                pwinput = Console.ReadLine();

                attempts++;
            } while (!uinput.Equals(user) && !pwinput.Equals(pw) && attempts != 2);
            if (uinput.Equals(user) && pwinput.Equals(pw))
            {
                Console.WriteLine("Log In Successfully");
            }
            else if (uinput.Equals(user))
            {
                do
                {
                    Console.WriteLine("Invalid password");
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
                    Console.WriteLine("INvalid usernname");
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
        }
    }
}