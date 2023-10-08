/*
 * Repeatable Repeat Phrase
 * Pawelski
 * 10/8/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Trace the program and predict what it will display. Then run the program to
 * check your work. Finally, be prepared to discuss the following questions...
 * 1. Based on this example, is it possible to have a loop inside a while loop?
 * 2. Based on this example, how would you make any program repeat while the user
 *    wants to repeat the program?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatableRepeatPhrase
{
    class Program
    {
        static void Main(string[] args)
        {
            int times;
            string phrase, repeat = "yes";
            while (repeat == "yes")
            {
                Console.Write("Enter a phrase >> ");
                phrase = Console.ReadLine();
                Console.Write("Times to repeat >> ");
                times = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < times; i++)
                {
                    Console.WriteLine(phrase);
                }
                Console.Write("Would you like to repeat? (yes/no) >> ");
                repeat = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
