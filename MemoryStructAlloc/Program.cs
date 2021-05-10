using MemoryStructAlloc.Structures;
using System;

namespace MemoryStructAlloc
{
    class Program
    {
        static void Main(string[] args)
        {

            //var newType = new UserType();
            //newType.x = 7;
            //newType.y = 99;

            //Console.WriteLine(newType.x);

            // Создаем значимый тип
            //Point p;
            //p.x = 1;
            //p.y = 2;

            // Упаковка переменной и отправка в кучу
            //object obj = p;

            //p.x = 7;

            // obj = p;  - гавно, т.к. будет содаваться новый объект и меняться указатель, ОЗУ заполнится очень быстро

            /*

            int i = 7;
            Console.WriteLine($"{i},{i},{i}"); // Гавно, т.к. будет происходить упаковка для каждой указанной переменной, даже если она та же, засорение памяти

            Выход:
            int i = 7;
            object o = i;
            Console.WriteLine($"{o},{o},{o}"); // Один раз запаковать в object и дальше упаковок не будет
            
            */

            Point p1 = new Point(10, 10);
            Point p2 = new Point(20, 20);

            Console.WriteLine( p1.ToString() );

            Console.ReadLine();
        }
    }
}
