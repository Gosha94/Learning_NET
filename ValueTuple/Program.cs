using System;

namespace ValueTuple_Cortages
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Обычная форма записи

            var valTuple = (1, 3, "Value");
            Console.WriteLine($"{valTuple.Item1},{valTuple.Item2}, {valTuple.Item3}");

            #endregion

            #region Защищенная форма записи

            ValueTuple<int, string, int> tup2 = (1, "Dva", 3);
            (int,string,int) tup21 = (1, "Dva", 3);

            #endregion

            #region Бесконечный кортеж

            var fibonacci = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, "17", 18, "19", 20, 21, 22);

            #endregion

            #region Использование псевдонимов для  переменных

            (int Age, string Name) person = (18, "Peter");
            Console.WriteLine(person.Age);
             var human = (Name: "Ivan", Age: 16);

            #endregion

            #region Игнорирование псевдонимов правой части выражения

            (int Age, string Name) chel = (Vozrast: 18, Klichka: "Peter");
            //chel.Name;
            //chel.Age;

            #endregion

            #region Исп. переменных как псевдонимов

            var name = "Sanya";
            var age = 14;

            var bestPeople = (name, age);
            //bestPeople.name;
            //bestPeople.age;

            #endregion

            #region Передача кортежей в методы

            var pair2 = (a: 10, b: 20);
            var res = CalcMinMax(pair2);

            #endregion

            #region Деконструкторы
            
            // Объявляем переменные и разбиваем кортеж по ним
            (string firstName, string secondName, int age1)= WhoAmI();
            
            // Объявляем переменную, и возвращаем только одно значение, остальные выкидываем
            (_, _, int age2) = WhoAmI();

            #endregion

        }

        private static (int, int) CalcMinMax((int First, int Second) pair)
        {
            return (Math.Min(pair.First, pair.Second), Math.Max(pair.First, pair.Second));
        }

        private static (string firstName, string secondName, int age) WhoAmI()
        {
            return ("Georgy", "Ivanov", 18);
        }

    }
}
