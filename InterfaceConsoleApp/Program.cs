using System;

namespace InterfaceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double testVal = 1.5d;
            var zelPart = Math.Truncate(testVal);
            double ostatok = testVal - zelPart;
            Console.WriteLine($"{ostatok}");
            Console.ReadLine();           

        }
    }
}
