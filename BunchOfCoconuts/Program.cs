/*
 * Bunch of Coconuts
 * Pawelski
 * 10/8/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Trace the program and predict what it will display. Then run the program to
 * check your work. As you may have noticed, while you can nest while loops, it gets
 * very messy! Modify the program so that it uses for loops instead of while loops.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunchOfCoconuts
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 4)
            {
                Console.WriteLine("I have a lovely bunch of coconuts standing in a row.");
                int j = 0;
                while (j < 3)
                {
                    Console.WriteLine("Big ones, small ones...");
                    j += 1;
                }
                i += 1;
                Console.WriteLine("Some as big as your head!");
            }
                
        }
    }
}
