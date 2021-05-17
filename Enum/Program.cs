using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = (int)TrickScore.Fetch * 3;
            Console.WriteLine(value.ToString());
            // Можно выполнитьобратное приведениеint к TrickScore.Таккак значение равно 30,
            // результатом станет TrickScore.Speak.
            // Соответственно метод score.ToString() возвращает “Speak”.
            TrickScore score = (TrickScore)value;
            Console.WriteLine(score.ToString());
            Console.ReadLine();
        }
    }
}
