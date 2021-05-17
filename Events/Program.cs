 using Events.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.GoToSleep += Person_GoToSleep;
            person.GoToSleep += Blessing;
            person.GoToSleep += Final;
            person.TakeTime(DateTime.Parse("13.10.2020 21:00:00"));
            person.TakeTime(DateTime.Parse("13.10.2020 8:00:00"));

            var operationMul = OperationType(1,3,Calculation_Mul);
            var operationSum = OperationType(4, 7, Calculation_Sum);

            Console.WriteLine(operationMul);
            Console.WriteLine(operationSum);

            Console.ReadLine();
        }


        private static void Person_GoToSleep()
        {
            Console.WriteLine("Человек пошел спать.");            
        }       
        private static void Blessing()
        {
            Console.WriteLine("Человек молодец.");            
        }
        private static void Final()
        {
            Console.WriteLine("Будь как человек.");            
        }
        
        /// <summary>
        /// Общая конструкция контейнера, для конструирования метода с переданными в контейнер параметрами
        /// /// </summary>
        /// <param name="a">Первый оператор</param>
        /// <param name="b">Второй оператор</param>
        /// <param name="calculation">Метод, соответствующий шаблону: выходной тип int, и два параметра int</param>
        /// <returns></returns>
        private static int OperationType(int a, int b, Func<int, int, int> calculation)
        {
            return calculation(a, b);
        }
        private static int Calculation_Sum(int i, int j)
        {
            return i + j;
        }
        private static int Calculation_Mul(int i, int j)
        {
            return i * j;
        }

    }
}
