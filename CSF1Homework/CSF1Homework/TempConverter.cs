using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main()
        {
            bool repeat = true;
            do
            {
                Console.Title = "Temperature Converter";
                decimal d1 = 1.8m;
                Console.WriteLine("What would you like to do?\n C)elcius to Ferenheight\n F)erenheight to Celsius\n E)xit");
                ConsoleKey menuSelection = Console.ReadKey(true).Key;
                Console.Clear();
                switch (menuSelection)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("Enter a temperature in Celsius: ");
                        decimal tempCel = decimal.Parse(Console.ReadLine());
                        decimal tempFer = ((tempCel * d1) + 32);
                        Console.WriteLine("Your temperature in Ferenheight is " + tempFer + "\u00B0");
                        Console.WriteLine("Do you have another conversion?");
                        string menuSelection2 = Console.ReadLine().ToUpper();
                        if (menuSelection2 == "N" || menuSelection2 == "NO")
                        {
                            repeat = false;
                        }
                        else if (menuSelection2 == "Y" || menuSelection2 == "YES")
                            repeat = true;
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine("Enter a temperature in Ferenheight:");
                        decimal tempFer2 = decimal.Parse(Console.ReadLine());
                        decimal tempCel2 = ((tempFer2 - 32) / d1);
                        Console.WriteLine("Your temperature in Celsius is " + tempCel2 + "\u00B0");
                        Console.WriteLine("Do you have another conversion?");
                        string menuSelection3 = Console.ReadLine().ToUpper();
                        if (menuSelection3 == "N" || menuSelection3 == "NO")
                        {
                            Console.WriteLine("Goodbye");
                            repeat = false;
                        }
                        else if (menuSelection3 == "Y" || menuSelection3 == "YES")
                            repeat = true;
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Goodbye.");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("I don't know what you want. Start over and try again");
                        break;
                } 
            }while (repeat == true) ;






        }
    }
}
