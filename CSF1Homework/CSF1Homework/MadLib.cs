using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main()
        {
            Console.Title = "Once upon a time, in the year 2020";
            string[] adLib = new string[] { "pronoun", "noun", "place", "adjective", "adverb", "noun",
                "pronoun", "location", "adverb", "famous person", "adverb", "past tense verb"};
            string[] vowel = new string[] { "A", "E", "I", "O", "U", "H" };//how to change a to an based on first letter of input?
                string[] input = new string[adLib.Length];
            for (int a = 0; a < adLib.Length; a++)
            {
                Console.WriteLine("Enter a " + adLib[a]);
                input[a] = Console.ReadLine();
            }
            /*if (input[a] == input[3])//attempting to create substring to do a vowel check
            {
               string vCheck = input.Substring(0, 0);
            }*/

            Console.WriteLine($"{input[0]} woke up to more strange news. {input[1]} had been discovered in " +
                $"{input[2]} by a(n) {input[3]} \narcheologist.This was {input[4]} usurped by the arrival of {input[5]} " +
                $"in {input[6]}’s {input[7]}. All would \nhave ended {input[8]} if not for the heroic actions of " +
                $"{input[9]} who {input[10]} {input[11]}!");

        }
    }
}
