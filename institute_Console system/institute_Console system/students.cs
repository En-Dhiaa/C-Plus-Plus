using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace institute_Console_system
{
    class students : person
    {
        private string level;
        public override void Add()
        {

            Console.Title = "Institute System";
            try
            {
                base.Add(); Console.Write("LEVEL: "); level = Console.ReadLine();
                instituteEntities db = new instituteEntities();
               
               studentDataTable allinfo = new studentDataTable();
                allinfo.id = 1;
                allinfo.name = "Ali";
                allinfo.phone = "7451";
                allinfo.age = 45;
                allinfo.birth = "4558";
                allinfo.adderss = "hell street";
                allinfo.level = "7";
                db.studentDataTables.Add(allinfo);
                db.SaveChanges();
                Console.WriteLine("Saved Successfully");



            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }
        public override void Delete()
        {
            base.Delete(); level = null;
        }
        public override void Show()
        {

            base.Show();
            Console.Write("LEVEL: " + level);
            Console.WriteLine("______________________________");
        }
        public override void Update()
        {

            base.Update();
            Console.WriteLine("LEVEL: "); level = Console.ReadLine();
            Console.WriteLine("\n______________________________");
        }
        public void Student_info()
        {
            Console.Clear();
            bool con = true;
            while (con)
            {

              
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t                                                        |     ");
                Console.WriteLine("\t                                                      \\ _ /        ");
                Console.WriteLine("\t                                                    -- (_) --        ");
                Console.WriteLine("\t                                                      /   \\         ");
                Console.WriteLine("\t                                                        |      ");
                Console.WriteLine("\t                                                              ");
                Console.WriteLine("\t          ,,,,,,,,,                                           ");
                Console.WriteLine("\t          _ _ _ _ _                                           ");
                Console.WriteLine("\t        /   _   _  \\                                         ");
                Console.WriteLine("\t       /   |_| |_|  \\        ________________________ ");
                Console.WriteLine("\t      /______________\\      |                        |");
                Console.WriteLine("\t      |   __    __   |      | [1] Add    [3] Update  |");
                Console.WriteLine("\t      |  /  \\  /  \\  |      | [2] Show   [4] Delete  |       __________________    ");
                Console.WriteLine("\t      |  |..|  |..|  |      |       [5] Exit         |      |[_][_][_][_][_][_]|   ");
                Console.WriteLine("\t      |  |__|  |__|  |      |_______________________ |      |o _         _  _  |   ");
                Console.WriteLine("\t _____|______________|_____________||_______||_______________`(_)-------(_)(_)-''________  \n\n\n\n ");
                

                int choice;
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
        }
    }
}
