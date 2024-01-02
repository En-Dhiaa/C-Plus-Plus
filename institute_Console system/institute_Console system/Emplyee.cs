using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institute_Console_system
{
    class Emplyee : person
    {
        private decimal sal;
        public decimal Sal { get; set; }
        private string job;
        public string Job { get; set; }
        public override void Add()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ID: "); Id = int.Parse(Console.ReadLine());
                Console.Write("NAME: "); Name = Console.ReadLine();
                Console.Write("PHONE: "); Phone = Console.ReadLine();
                Console.Write("AGE: "); Age = int.Parse(Console.ReadLine());
                Console.Write("BIRTH DATE: "); Birth = Console.ReadLine();
                Console.Write("ADDRESS: "); Adderss = Console.ReadLine(); Console.Write("SALARY: "); sal = decimal.Parse(Console.ReadLine());
                Console.Write("Job: "); job =Console.ReadLine();
            }
            catch(Exception e2){
                Console.WriteLine(e2.Message);
            }
        }
        public override void Delete()
        {
            base.Delete(); sal = 0;
        }
        public override void Show()
        {

            // Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("______________________________");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("PHONE: " + Phone);
            Console.WriteLine("AGE: " + Age);
            Console.WriteLine("BIRTH DATE: " + Birth);
            Console.WriteLine("ADDRESS: " + Adderss);
            Console.WriteLine("SALARY: " + sal);
            Console.WriteLine("______________________________");
        }
        public override void Update()
        {
            try
            {
                
                int choice;
                Console.WriteLine("______________________________");
                Console.WriteLine("[1]ID\t[2]NAME\t[3]PHONE\t\n[4]AGE\t[5]DATE OF BIRTH\t[6]ADDRESS\n\t[7]SALARY\t [8]JOB: ");
                Console.WriteLine("______________________________");
                Console.WriteLine("Enter your choice : "); choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1: Console.Write("ID: "); Id = int.Parse(Console.ReadLine()); break;
                    case 2: Console.Write("NAME: "); Name = Console.ReadLine(); break;
                    case 3: Console.Write("PHONE: "); Phone = Console.ReadLine(); break;
                    case 4: Console.Write("AGE: "); Age = int.Parse(Console.ReadLine()); break;
                    case 5: Console.Write("BIRTH DATE: "); Birth = Console.ReadLine(); break;
                    case 6: Console.Write("ADDRESS: "); Adderss = Console.ReadLine(); break;
                    case 7: Console.WriteLine("Salary: "); sal = int.Parse(Console.ReadLine()); break;
                    case 8: Console.Write("JOB: "); job = Console.ReadLine(); break;
                    default: Console.WriteLine("Erorr......"); break;
                }
            }
            catch(Exception e3){
                Console.WriteLine(e3.Message);
            }
            Console.WriteLine("*Updated successfuly........ ");
        }
        public void Employee_info()
        {
            Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Magenta;
            bool con = true;
            while (con)
            {
                Console.WriteLine("\t_________________________________________");
                Console.WriteLine("\t\t\t Employee \t\t");

                Console.WriteLine("\t ________________________________________");
                Console.WriteLine("\t|            i\\                          |");
                Console.WriteLine("\t|            I \\                         |");
                Console.WriteLine("\t|            I  \\         [1] Add        |");
                Console.WriteLine("\t|            I   \\        [2] Show       |");
                Console.WriteLine("\t|            I    \\       [3] Update     |");
                Console.WriteLine("\t|            I     \\      [4] Delete     |");
                Console.WriteLine("\t|            I      \\     [5] Exit       |");
                Console.WriteLine("\t|            I_______\\                   |");
                Console.WriteLine("\t|     _______I__O__________________      |");
                Console.WriteLine("\t|     \\           ( )             /      |");
                Console.WriteLine("\t|____^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^____|");

                int choice;
                try
                {
                    Console.WriteLine("Enter your choice: "); choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: Add(); break;
                        case 2: Show(); break;
                        case 3: Update(); break;
                        case 4: Delete(); break;
                        case 5: con = false; break;
                        default: Console.WriteLine("\t\t error\n\t Invalid value......"); break;
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}
