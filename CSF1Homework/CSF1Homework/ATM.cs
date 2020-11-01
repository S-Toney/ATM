using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main()
        {
            Console.Title = "Account Login";
            string account = "12345";
            string PIN = "6789";
            string uAccount;
            string pass;
            decimal balance = 500;
            int chances = 0;
            bool repeat = true;
            do
            {
                Console.WriteLine("Enter your account number: ");
                uAccount = Console.ReadLine();
                chances++;
            } while (uAccount != account && chances < 3);
            if (uAccount == account)
            {
                chances = 0;
                do
                {
                    Console.WriteLine("Enter your PIN #: ");
                    pass = Console.ReadLine();
                    chances++;
                } while (pass != PIN && chances < 3);
                if (pass == PIN)
                {
                    Console.WriteLine("Welcome");
                    Console.Title = ($"Account Balance: {balance:c}");
                    do
                    {
                        Console.WriteLine("What would you like to do?\n D)eposit\n W)ithdraw\n E)xit");
                        ConsoleKey menu = Console.ReadKey(true).Key;
                        Console.Clear();
                        switch (menu)
                        {
                            case ConsoleKey.D:
                                Console.WriteLine("How much would you like to deposit?");
                                decimal deposit = decimal.Parse(Console.ReadLine());
                                balance += deposit;
                                Console.Title = ($"Account Balance: {balance:c}");
                                Console.WriteLine($"{deposit:c} has been added to account number {account}.\n{balance:c}\n");
                                Console.WriteLine("Would you like to make another selection?");
                                string menu2 = Console.ReadLine().ToUpper();
                                if (menu2 == "N" || menu2 == "NO")
                                {
                                    Console.WriteLine("We appreciate your business. Goodbye.");
                                    repeat = false;
                                }
                                else if (menu2 == "Y" || menu2 == "YES")
                                    repeat = true;
                                break;
                            case ConsoleKey.W:
                                Console.WriteLine("How much would you like to withdraw?");
                                decimal withdraw = decimal.Parse(Console.ReadLine());
                                balance -= withdraw;
                                Console.Title = ($"Account Balance: {balance:c}");
                                Console.WriteLine($"{withdraw:c} has been withdrawn from account number {account}.\n{balance:c}\n");
                                Console.WriteLine("Would you like to make another selection?");
                                string menu3 = Console.ReadLine().ToUpper();
                                if (menu3 == "N" || menu3 == "NO")
                                {
                                    Console.WriteLine("We appreciate your business. Goodbye.");
                                    repeat = false;
                                }
                                else if (menu3 == "Y" || menu3 == "YES")
                                    repeat = true;
                                break;
                            case ConsoleKey.E:
                                Console.WriteLine("We appreciate your business. Goodbye.");
                                repeat = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice, please try again.");
                                break;
                        }
                    } while (repeat == true);
                }
            }
            else
            {
                Console.WriteLine("ACCOUNT LOCKED\nCall Customer Service\n");
            }
        }
    }
}
