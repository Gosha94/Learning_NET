using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfElements = new List<string>
            {
                "One",
                "Two",
                "Three"
            };

            List<string> emptyList = new List<string>();

            var result = emptyList.First();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
