using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.Owner owner = new Classes.Owner();
            Classes.Safe safe = new Classes.Safe();
            Classes.JewelThief jewelThief = new Classes.JewelThief();
            jewelThief.OpenSafe(safe, owner);
            Console.ReadKey();
        }
    }
}
