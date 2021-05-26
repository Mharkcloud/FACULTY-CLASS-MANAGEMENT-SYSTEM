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
            
            Usrs users = new Usrs();
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
                Console.WriteLine("\n\t\tDo you want to view the Summary of Absent of all Faculty Member?");
                Console.WriteLine("\n\t\t01. Yes");
                Console.WriteLine("\n\t\t02. No");
                Console.Write("\n\nEnter the number of your choices: \n\n");
                char optionSelected = Console.ReadLine()[1];
                switch (optionSelected)
                {
                    case '1':
                        Console.WriteLine("\nYes");
                        Console.WriteLine("\n\t\t\t\t\t\t---------------------------------------------------------------");
                        List<Summary> summaries = new List<Summary>();
                        summaries.Add(new Summary());
                        summaries[0].Name = "\nJohn Mhark M. Ren";
                        summaries[0].Absent = 3;
                        summaries.Add(new Summary());
                        summaries[1].Name = "\nJohn Edward Gonzales";
                        summaries[1].Absent = 1;
                        summaries.Add(new Summary());
                        summaries[2].Name = "\nZaly Manigbas";
                        summaries[2].Absent = 2;

                        foreach (Summary summary in summaries)
                        {
                            Console.WriteLine(summary.getData());
                        }
                        Console.ReadLine();
                        break;
                    case '2':
                        Console.WriteLine("No");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                        Console.WriteLine("\n\t\t\t\t\t\t---------------------------------------------------------------");
                Console.WriteLine("\n\n\nDo you want to view the Teacher's List?\n\n\n");
                Console.WriteLine("\n\t\t01. Yes");
                Console.WriteLine("\n\t\t02. No");
                Console.Write("\n\nEnter the number of your choices: \n\n");
                char optionSelected1 = Console.ReadLine()[2];
                Console.WriteLine("\n\n\n\t\t\t\t\t\t----------------------Teacher's List----------------------\n\n\n\t\t\t\t\t\t");
                
                switch (optionSelected1)
                {
                    case '2':
                        Console.WriteLine("\nYes");
                        Console.WriteLine("\n\t\t\t\t\t\t---------------------------------------------------------------");
                        List<List> lists = new List<List>();
                        lists[0].Name1 = "\nJohn Mhark M. Ren";
                        lists[1].Name2 = "\nJohn Edward Gonzales";
                        lists[2].Name3 = "\nZaly Manigbas";

                        foreach (List list in lists)
                        {
                            Console.WriteLine(list.getData());
                        }
                        Console.ReadLine();
                        break;
                    case '3':
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