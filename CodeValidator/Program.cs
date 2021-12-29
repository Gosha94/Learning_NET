using System;
using System.Collections.Generic;

namespace CodeValidator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var numb = 2L;
            
            // Будем брать сумму последних элементов из LIFO
            Stack<long> consecutiveNumbersList = new Stack<long>();

            var elemCount = 0L;
            
            // найти общее кол-во элементов
            // 2 строки = 1 + 2 = 3 элем нужно вкинуть в массив
            for (long i = 1; i <= numb; i++)
            {
                elemCount += i;
            }
            
            var maxNumInPrevRow = 1L;

            for (int i = 0; i < elemCount;)
            {
                if (maxNumInPrevRow % 2 != 0)
                {
                    consecutiveNumbersList.Push(maxNumInPrevRow);
                    i++;
                }
                maxNumInPrevRow++;
            }

            var resultSum = 0L;
            for (long i = 0; i < numb; i++)
            {
                resultSum += consecutiveNumbersList.Pop();
            }

            Console.ReadLine();
        }



        public static long rowSumOddNumbers(long n)
        {
            return n * n * n;
        }

        public static long rowSumOddNumbers(long n) => (long)Math.Pow(n, 3);
    

}
}
