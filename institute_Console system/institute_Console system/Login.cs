using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institute_Console_system
{
    class Login
    {
        static int[] Do = new int[] { 131, 262, 523, 1046 };
        static int[] RE = new int[] { 147, 294, 587, 1174 };
        static int[] MI = new int[] { 165, 330, 659, 1318 };
        static int[] FA = new int[] { 175, 349, 698, 1396 };
        static int[] SO = new int[] { 196, 392, 784, 1568 };
        static int[] LA = new int[] { 220, 440, 880, 1760 };
        static int[] TI = new int[] { 247, 494, 988, 1976 };
     
        public void user_admin()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▓▓▓░░░░░░░░░░░░░░▓▓▓▓▓▓░░░░░░░░░░░░▓▓▓▓▓▓░░░░░░░▓▓▓▓▓░░░░░░▓▓▓▓░░░░░░▓▓▓░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▓▓▓░░░░░░░░░░░▓▓▓░░░░░░▓▓▓░░░░░░░▓▓▓░░░░░░░░░░░░░▓▓▓░░░░░░░▓▓▓░▓░░░░░▓▓▓░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▓▓▓░░░░░░░░░░▓▓▓░░░░░░░░▓▓▓░░░░▓▓▓░░░░░░░░░░░░░░░▓▓▓░░░░░░░▓▓▓░░▓░░░░▓▓▓░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▓▓▓░░░░░░░░░▓▓▓░░░░░░░░░░▓▓▓░░▓▓▓░░░░░░▓▓▓▓▓▓░░░░▓▓▓░░░░░░░▓▓▓░░░▓░░░▓▓▓░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▓▓▓░░░░░░░░░░▓▓▓░░░░░░░░▓▓▓░░░░▓▓▓░░░░░░░░▓▓▓░░░░▓▓▓░░░░░░░▓▓▓░░░░▓░░▓▓▓░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▓▓▓░░░░░░░░░░░▓▓▓░░░░░░▓▓▓░░░░░░░▓▓▓░░░░░░▓▓▓░░░░▓▓▓░░░░░░░▓▓▓░░░░░▓░▓▓▓░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░▓▓▓▓▓▓▓▓▓░░░░░░░░▓▓▓▓▓▓░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░▓▓▓▓▓░░░░░░▓▓▓░░░░░░▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

            
            Console.Title = "Institute System ";
            int mus1 = 0;
            int mus2 = 1;
            int mus3 = 2;
            int mus4 = 3;
            int mus5 = 5;

            Console.Beep(Do[mus4], 350);
            Console.Beep(RE[mus4], 300);
            Console.Beep(MI[mus4], 350);
            Console.Beep(FA[mus4], 300);
            Console.Beep(SO[mus4], 350);
            Console.Beep(LA[mus4], 300);
            Console.Beep(TI[mus4], 350);
            Console.Beep(Do[mus4], 300);


            string username = "*******";
            string Password = "*********";
            int success = 0;
            Console.WriteLine(@"
               
                          _   _
                          \ `/ |
                           \__`!
                           / ,' `-.__________________
  _______________          '-'\_____                 LI`-.
 |    WELCOME    |__________   <____()-=O=O=O=O=O=[]====--)
 |_______________|              `.___ ,-----,_______...-'
                                     /    .'
                                    /   .'
                                   /  .' 
                                   `->

");
            do
            {
                Console.Write("Enter Username : ");
                username = Console.ReadLine();
                Console.Write("Enter the password : ");
                Password = Console.ReadLine();
                if ((username == "admin" || username == "ADMIN") && (Password == "admin" || Password == "ADMIN"))
                {
                    success = 1; 
                }
                else
                {
                    Console.WriteLine("\a Wrong username or Password ");
                    Console.WriteLine("\a Try Again please ................. \n \n");
                }
            } while (success != 1);
           
        }

        
    }
}
