/*
 * Nested Loops 2
 * Pawelski
 * 10/8/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Trace the program and predict what it will display. Then run the program to
 * check your work. Finally, be prepared to discuss the following questions...
 * 1. Compare the previous program and this program. How does the output differ?
 *    Why do you think this happened?
 * 2. How many times does the inner loop repeat for each pass of the outer loop?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 6; j += 2)
                {
                    Console.WriteLine(j + "\t" + i);
                }
            }
        }
    }
}
