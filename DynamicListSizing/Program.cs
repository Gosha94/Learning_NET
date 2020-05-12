using System.Collections.Generic;

using DynamicListSizing.Enums;
using DynamicListSizing.Classes;
using System;

namespace DynamicListSizing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe()
            { Style = Style.Clogs, Color = "Черный" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Flipflops, Color = "Белый" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Loafers, Color = "Зеленый" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Sandals, Color = "Ультрамарин" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Бежевый" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Wingtips, Color = "Спортивный" });

            //Возвращает число объектов Shoe в перечислении
            int numberOfShoes = shoeCloset.Count;

            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Оранжевый";
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe = shoeCloset[1];

            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);

            if (shoeCloset.Contains(secondShoe))
                Console.WriteLine("Удивительно!");

        }
    }
}
