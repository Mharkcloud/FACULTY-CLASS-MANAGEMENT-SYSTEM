using System;
using static System.Console;
using FCMS.BL;
using FCMS.UI;
using System.Collections.Generic;

namespace FCMS.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\t\t\t----------------------WELCOME TO THE FACULTY CLASS MANAGEMENT SYSTEM----------------------\n\n");
            Console.WriteLine("\n\nEnter the number of your selected from the selection.\n\n");
            
            var arrUsers = new Users[]
                {
            new Users("D","E",1),
            new Users("N","I",2),
            new Users("S","Rafi",3)
                };

        Start:
            Console.WriteLine("\nlogin (1) | Register (2)\n"); 
            var input = Console.ReadLine();
            bool successfull = false;
      
            while (!successfull)
            {
                if (input == "1")
                {
                    Console.Write("\nUsername: \n");
                    var username = Console.ReadLine();
                    Console.Write("\nPassword: \n");
                    var password = Console.ReadLine();

                    foreach (Users user in arrUsers)
                    {
                        if (username == user.username && password == user.password)
                        {
                            Console.Write("\nLogin Successful\n");
                            Console.ReadLine();
                            successfull = true;
                            break;
                        }
                    }
                    if (!successfull)
                    {
                        Console.Write("\nError The Username or Password you Entered is Incorrect.\n");
                    }
                }
                else if (input == "2")
                {
                    Console.Write("\nUsername: \n");
                    var username = Console.ReadLine();
                    Console.Write("\nPassword: \n");
                    var password = Console.ReadLine();
                    Console.Write("\nId: \n");
                    int id = int.Parse(Console.ReadLine());
                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users(username, password, id);
                    successfull = true;
                    goto Start;
                }
                Console.WriteLine("\n\n\n\t\t\t\t\t\t---------------------------------------------------------------");
                Console.WriteLine("\n\t\tDo you want to view the List Name of all Faculty Member?");
                Console.WriteLine("\n\t\t01. Yes");
                Console.WriteLine("\n\t\t02. No");
                Console.Write("\n\nEnter the number of your choices: \n\n");
                Char optionSelected1 = Console.ReadLine()[1];
                switch (optionSelected1)
                {
                    case '1':
                        Teachername myObj = new Teachername();
                        myObj.Name = "\n\nLiam Martinez\n";
                        myObj.Name1 = "Mhark Macasaet\n";
                        myObj.Name2 = "Linda Cruz";
                        Console.WriteLine(myObj.Name);
                        Console.WriteLine(myObj.Name1);
                        Console.WriteLine(myObj.Name2);
                        break;
                    case '2':
                        Console.WriteLine("No");
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
                char optionSelected = Console.ReadLine()[1];
                switch (optionSelected)
                {
                    case '1':
                        Summaries myObj = new Summaries();
                        myObj.Name = "\n\nLiam Martinez";
                        myObj.Name1 = "Mhark Macasaet";
                        myObj.Name2 = "Linda Cruz";
                        Console.WriteLine(myObj.Name + " has 3 absent.\n");
                        Console.WriteLine(myObj.Name1 + " has 2 absent.\n");
                        Console.WriteLine(myObj.Name2 + " has 2 absent.\n");
                        break;
                    case '2':
                        Console.WriteLine("No");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}
// Tulad nga po mam last meeting pinaghiwalay ko na po yung mga classes. Dun po sa Users na class maam ang ginamit
// ko po is field pa rin medyo nalilito ako parang dun ako nasanay then yung 2 classes ko is get and set na po ginawa ko.
// pinag hiwalay hiwalay ko na rin po sila base single purposes nila salamat po.