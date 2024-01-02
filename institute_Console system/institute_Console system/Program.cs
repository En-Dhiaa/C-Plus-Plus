using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institute_Console_system
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Institute System ";
            Login l = new Login();
            l.user_admin();
            bool con = true;
            

            while (con)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
              
                Console.Clear();
               
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t                         |  INSTITUTE  |                                |     ");
                Console.WriteLine("\t                         \\'''''''''''''/                              \\ _ /        ");
                Console.WriteLine("\t                        )..............(                            -- (_) --                                ");
                Console.WriteLine("\t                       /................\\                             /   \\                                     ");
                Console.WriteLine("\t                      /..................\\                              |                                       ");
                Console.WriteLine("\t                     /....................\\                                                                       ");
                Console.WriteLine("\t          ,,,,,,,,,  |      ..       ..   |                                                                       ");
                Console.WriteLine("\t          _ _ _ _ _  |     /__\\     /__\\  |                                                                       ");
                Console.WriteLine("\t        /   _   _  \\ |    |    |   |    | |  ^           __________________                                        ");
                Console.WriteLine("\t       /   |_| |_|  \\|    |____|   |____| | / \\        |                   |                                         ");
                Console.WriteLine("\t      /______________\\                     /   \\       |    [1] STUDENT    |                                     ");
                Console.WriteLine("\t      |   __    __   |       _______      /_____\\      |    [2] EMPLOYEE   |                                     ");
                Console.WriteLine("\t      |  /  \\  /  \\  |      ((--.--))     | _  _ |     |    [3] COURSE     |           __________________      ");
                Console.WriteLine("\t      |  |..|  |..|  |      ||  |  ||     ||_||_||     |    [4] EXIT       |          |[_][_][_][_][_][_]|         ");
                Console.WriteLine("\t      |  |__|  |__|  |      ||  |  ||     ||_||_||     |___________________|          |o _         _  _  |         ");
                Console.WriteLine("\t _____|______________|______||..|..||_____|______|___________||_______||_______________`(_)-------(_)(_)-''________- \n\n\n ");

                int choice;
                try
                {
                    Console.Write("Enter your choice: "); choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: Student s1 = new Student();
                            s1.Student_info(); break;
                        case 2: Emplyee e1 = new Emplyee(); e1.Employee_info(); break;
                        case 3: Course c1 = new Course(); c1.DisPlay_Course(); break;
                        case 4: con = false; break;
                        default: Console.WriteLine("\t\t error\n\t Invalid value......"); break;
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            Console.WriteLine("\n\n\n\t\t THANK YOU FOR USING OUR SYSTEM......");
            Console.ReadKey();
        }

        
        
    }
}

