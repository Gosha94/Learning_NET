using System;
using System.Collections.Generic;
using DuckCollectioner.Enums;
using DuckCollectioner.Classes;

namespace DuckCollectioner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },                
            };
            // Эта ссылка на объект помогает методу List.Sort() упорядочить массив. Но Вам нужно указать начальные значения для списка.
            //DuckComparerBySize sizeComparer = new DuckComparerBySize();
            //ducks.Sort(sizeComparer);
            //PrintDucks(ducks);
            // Сортировка уток по видам
            //DuckComparerByKind kindComparer = new DuckComparerByKind();
            //ducks.Sort(kindComparer);
            //PrintDucks(ducks);
            // Третий вид сортировки и по размеру и по типу
            DuckComparerSizeAndKind sizeKindComparer = new DuckComparerSizeAndKind();

            sizeKindComparer.SortBy = SortCriteries.KindThenSize;
            ducks.Sort(sizeKindComparer);
            PrintDucks(ducks);

            sizeKindComparer.SortBy = SortCriteries.SizeThenKind;
            ducks.Sort(sizeKindComparer);
            PrintDucks(ducks);

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            Console.WriteLine("\n");
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.Size.ToString() + "-дюймов " + duck.Kind.ToString());
            Console.WriteLine("Утки кончились!");
        }
    }
}
