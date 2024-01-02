using System;


namespace institute_Console_system
{
    class Student : person
    {
        private string level;
        public string Level { get; set; }
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
                Console.Write("ADDRESS: "); Adderss = Console.ReadLine(); le_selection();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
        public override void Delete()
        {
            base.Delete(); level = null;
        }
        public override void Show()
        {

            base.Show();
            Console.WriteLine("LEVEL: " + level);
            Console.WriteLine("______________________________");
        }
        public override void Update()
        {

            
            int choice;
            Console.WriteLine("______________________________");
            Console.WriteLine("[1]ID\t[2]NAME\t[3]PHONE\t\n[4]AGE\t[5]DATE OF BIRTH\t[6]ADDRESS\n\t[7]LEVEL");
            Console.WriteLine("______________________________");
            try
            {
                Console.WriteLine("Enter your choice : "); choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1: Console.Write("ID: "); Id = int.Parse(Console.ReadLine()); break;
                    case 2: Console.Write("NAME: "); Name = Console.ReadLine(); break;
                    case 3: Console.Write("PHONE: "); Phone = Console.ReadLine(); break;
                    case 4: Console.Write("AGE: "); Age = int.Parse(Console.ReadLine()); break;
                    case 5: Console.Write("BIRTH DATE: "); Birth = Console.ReadLine(); break;
                    case 6: Console.Write("ADDRESS: "); Adderss = Console.ReadLine(); break;
                    case 7: le_selection(); break;
                    default: Console.WriteLine("Error......"); break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("*Updated successfully........ ");
        }
        public void le_selection()
        {

            try
            {
                int select;
                Console.WriteLine("______________________________");
                 Console.WriteLine(">>>>>>::: DEPARTMENT :::<<<<<<<<<<\n____________________________________\n \t[1]ENGLISH\n\t\t[2]COMPUTER\n___________________________________ ");
                select = int.Parse(Console.ReadLine());
                if (select == 1) English();
                else if (select == 2) computer();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message );
            }

        }
        public void Student_info()
        {
            Console.Clear();
            bool con = true;
            while (con)
            {
                // Console.BackgroundColor = ConsoleColor.Blue;
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


        public void English()
        {

           
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"

                                           |
                                           |
                                           |
                                         .-'-.
                                        ' ___ '
                              ---------'  .-.  '---------
               _________________________' '-' '___________________________
                ''''''-|---|--/    \==][^',_m_,'^][==/    \--|---|-''''''
                              \    /  ||/   H   \||  \    /
                               '--'   OO   O|O   OO   '--'
                                    
          ");
            Console.WriteLine("\t\t\t\t|-->>     ENGLISH      <<--|");
            Console.WriteLine("\t\t\t\t|--------------------------|");
            Console.WriteLine("\t\t\t\t|-->> (1) LITERACY     <<--|");
            Console.WriteLine("\t\t\t\t|-->> (2) ACCESS A     <<--|");
            Console.WriteLine("\t\t\t\t|-->> (3) ACCESS B     <<--|");
            Console.WriteLine("\t\t\t\t|-->> (4) STARTER A    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (5) STARTER B    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (6) LEVEL 1A     <<--|");
            Console.WriteLine("\t\t\t\t|-->> (7) LEVEL 1B     <<--|");
            Console.WriteLine("\t\t\t\t|-->> (8) wRITING 1    <<--|");
            Console.WriteLine("\t\t\t\t|--------------------------|");
            Console.WriteLine("\t\t\t\t|-->> (9) LEVEL 2A     <<--|");
            Console.WriteLine("\t\t\t\t|-->> (10) LEVEL 2B    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (11) LEVEL 3A    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (12) LEVEL 3B    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (13) wRITING 2   <<--|");
            Console.WriteLine("\t\t\t\t|--------------------------|");
            Console.WriteLine("\t\t\t\t|-->> (14) LEVEL 4A    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (15) LEVEL 4B    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (16) LEVEL 5A    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (17) LEVEL 5B    <<--|");
            Console.WriteLine("\t\t\t\t|-->> (18) wRITING 3   <<--|");
            Console.WriteLine("\t\t\t\t|--------------------------|");
            try
            {

                int choice; Console.WriteLine("enter the number of the level"); choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: level = "LITERACY"; break;
                    case 2: level = " ACCESS A"; break;
                    case 3: level = "ACCESS B"; break;
                    case 4: level = "STARTER A"; break;
                    case 5: level = "STARTER B"; break;
                    case 6: level = " LEVEL 1A"; break;
                    case 7: level = "LEVEL 1B"; break;
                    case 8: level = "wRITING 1 "; break;
                    case 9: level = "LEVEL 2A"; break;
                    case 10: level = " LEVEL 2B "; break;
                    case 11: level = "LEVEL 3A"; break;
                    case 12: level = "LEVEL 3B"; break;
                    case 13: level = "wRITING 2"; break;
                    case 14: level = " LEVEL 4A"; break;
                    case 15: level = "LEVEL 4B"; break;
                    case 16: level = "LEVEL 5A"; break;
                    case 17: level = "LEVEL 5B"; break;
                    case 18: level = "wRITING 3"; break;

                    default: Console.WriteLine("\t\t error\n\t Invalid value......"); break;



                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
        public void computer()
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"

                                    ___________                ---------------------------
                                   |.---------.|              |-->>      COMPUTER     <<--|
                                   ||         ||              |---------------------------|
                                   ||         ||              |-->> (1) Secretaryship <<--|
                                   ||         ||              |-->> (2) programs      <<--|
                                   |'---------'|              |-->> (3) Graphics      <<--|
                                    `)__ ____('               |-->> (4) other         <<--|
                                    [=== -- o ]--.            |---------------------------|
                                  __'---------'__  \
                                 [::::::::::: :::]  )
                                 `'''''''''''''''` /T\
                                                   \_/
                                                                 ");

        
            try
            {

                int choice; Console.WriteLine("enter the number of the level"); choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: level = "Secretaryship"; break;
                    case 2: level = " programs"; break;
                    case 3: level = "Graphics"; break;
                    case 4: level = "other"; break;
                    

                    default: Console.WriteLine("\t\t error\n\t Invalid value......"); break;



                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}