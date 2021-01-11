using System;
using System.Threading;

namespace learningC_
{
    class Program
    {
        static void Main(string[] args)
        {

            // setup

            VisualSetup();
            Booting();
            Commands();


            Console.ReadKey();
        }

        static void VisualSetup()
        {
            Console.Title = "frOSt";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;
        }

        static void Booting()
        {
            int loadTime = 0;
            Random numberGen = new Random();
            loadTime = numberGen.Next(2000, 10001);

            Console.WriteLine("frOSt 0.1\n");
            Console.WriteLine("Booting into initial Alpha Build....");
            Thread.Sleep(loadTime);
            Console.Clear();
        }

        static void Commands()
        {
            int loop = 1;
            string currentDir = "C:\\";
            Console.WriteLine("frOSt 0.1");


            //commands
            while (loop == 1) {
                loop = 2;

                Console.Write(currentDir + ">");
                string command = Console.ReadLine();

                if (command.Contains("help")) {
                    Console.WriteLine("hello {name} | Says hello to you (how exciting)\n");
                    loop = 1;
                } else if (command.Contains("hello")) {
                    Console.WriteLine("Hello!\n");
                    loop = 1;
                } else if (command == "exit" || command == "shutdown") {
                    Console.WriteLine("Shutting down....\n");
                    Thread.Sleep(2000);
                    loop = 3;
                } else {
                    Console.WriteLine("Sorry, that command doesn't exist\n");
                    loop = 1;
                }
            }
        }
    }
}



//TODO      make a virtual filesystem stored in a text file
//TODO      add filenavigation commands, such as 'cd' and 'ls'
//!         look up the c# alternative to the python .split() method