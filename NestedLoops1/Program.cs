/*
 * Nested Loops 1
 * 1/18/2023
 * C#.NET I
 * 
 * Instructions:
 * Trace the program and predict what it will display. Then run the program to
 * check your work. Finally, be prepared to discuss the following questions...
 * 1. Why is it important to use two different loop control variables for the inner and
 *    outer loop?
 * 2. In total, how many times does the inner loop repeat?
 * 3. Does the outer loop control the left or right number? What about the inner loop?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 6; j += 2)
                {
                    Console.WriteLine(i + "\t" + j);
                }
            }
        }
    }
}
