using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main()
        {
            Console.Title = "Login";
            string userName = "ADMIN";
            string password = "Admin";
            string input;
            string pass;
            int chances = 0;
            do
            {
                Console.WriteLine("Enter your username: ");
                input = Console.ReadLine().ToUpper();
                chances++;
            } while (input != userName && chances < 3);
            if (input == userName)
            {
                Console.WriteLine($"WELCOME {userName}");
                chances = 0;
                do
                {
                    Console.WriteLine("Enter your password: ");
                    pass = Console.ReadLine();
                    chances++;
                } while (pass != password && chances < 3);
                if (pass == password)
                {
                    Console.WriteLine("ACCESS GRANTED");
                }
                else
                {
                    Console.WriteLine("ACCESS DENIED");
                }
            }
            else
            {
                Console.WriteLine("ACCESS DENIED");
            }

        }
    }
}
