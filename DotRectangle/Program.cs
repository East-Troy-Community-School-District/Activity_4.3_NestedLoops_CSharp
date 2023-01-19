/*
 * Dot Rectangle
 * 1/18/2023
 * C#.NET I
 * 
 * Instructions:
 * Trace the program and predict what it will display. Then run the program to
 * check your work. Modify the program so that is displays a rectangle of dots
 * that is 5 dots tall and 3 dots wide. Finally, be prepared to discuss the
 * following questions...
 * 1. What loop controls the number of rows?
 * 2. What loop controls the number of columns?
 * 3. What is the purpose of line 34 in the program?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
