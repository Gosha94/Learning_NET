using System;
using System.Collections.Generic;
using System.Linq;

namespace TemperaturesAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            In this exercise, you have to analyze records of temperature to find the closest to zero.
            You need to solve this puzzle using as little characters as possible.

            Input
             Line 1: N, the number of temperatures to analyze
             Line 2: The N temperatures expressed as integers ranging from -273 to 5526
             
            Output
             Display 0 (zero) if no temperatures are provided. Otherwise, display the temperature closest to 0.
             
            Constraints
             0 ≤ N < 10000

             Write a program that prints the temperature closest to 0 among input data. If two numbers are equally close to zero, positive integer 
             has to be considered closest to zero (for instance, if the temperatures are -5 and 5, then display 5).
             */
            int n = Console.ReadLine();
            int result = 0;
            
            if (n != 0) 
            {
                var inpArr = Console.ReadLine().Split(' ').Select(x => int.Parse(x));
                
                int maxMinus = 0, minPlus = 0;

                if (inpArr.Any(x => x < 0))
                {
                    maxMinus = inpArr.Where(x => x < 0).Max();
                    result = maxMinus;
                }
                if (inpArr.Any(x => x > 0))
                {
                    minPlus = inpArr.Where(x => x > 0).Min();
                    result = minPlus;
                }
                if (Math.Abs(maxMinus) == minPlus || result == 0)
                {
                    result = minPlus;
                }                
            }
            Console.WriteLine(result);
        }
    }
}
