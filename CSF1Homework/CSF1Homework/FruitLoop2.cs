using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main()
        {
            Console.Title = "Fruit Loop 2";
            string[] fruit = new string[] { "apple", "orange", "banana", "plum", "peach", "mango" };

            for (int fruitC = 0; fruitC < fruit.Length; fruitC++)
            {
                Console.WriteLine(fruit[fruitC]);
                Console.WriteLine(new string ('.', fruitC ));
            }
        }
    }
}
