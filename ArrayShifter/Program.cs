using System;
using System.Linq;
using ArrayShifter.IndexChanger;
using System.Collections.Generic;

namespace ArrayShifter
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayIndexChanger changer = new ArrayIndexChanger(3,"1 2 3 4", 1); // Result: 0 2 3
            var result = changer.GetChangedArray();

            Console.ReadLine();


        }
    }
}
