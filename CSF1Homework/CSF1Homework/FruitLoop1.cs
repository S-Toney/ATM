using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            Console.Title = "Fruit Loop 1";
            string[] fruit = new string[] { "banana", "apple", "pear", "plum", "cherry", "orange" };
            for (int fruitC = 0; fruitC < fruit.Length; fruitC++)
            {
                Console.WriteLine(fruit[fruitC]);
            }

        }
    }
}
