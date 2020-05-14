using System;
using SortCardsSimulator.Classes;
using SortCardsSimulator.Enums;
using System.Collections.Generic;

namespace SortCardsSimulator
{

    class Program
    {       

        static void Main(string[] args)
        {
            Random random = new Random();

            List<Card> cards = new List<Card> { // Generator of 5 random cards
             new Card() { Suit = (Suits)random.Next(4), Value = (Values)random.Next(1, 14) },  // Next(int32) возвращает неотрицательное меньше указанного, значит от 0 до 3
             new Card() { Suit = (Suits)random.Next(4), Value = (Values)random.Next(1, 14) },  // Next(int32, int32) возвращает от 0 до 13, верхний предел исключен, нижний включен
             new Card() { Suit = (Suits)random.Next(4), Value = (Values)random.Next(1, 14) },
             new Card() { Suit = (Suits)random.Next(4), Value = (Values)random.Next(1, 14) },
             new Card() { Suit = (Suits)random.Next(4), Value = (Values)random.Next(1, 14) },
            };

            Console.WriteLine("Пять случайных карт:");

            PrintCards(cards);

            CardComparerValueThenSuit cardComparer = new CardComparerValueThenSuit();
            cards.Sort(cardComparer);
            Console.WriteLine("Карты, отсортированные по увеличению крутости:");
            PrintCards(cards);
            Console.ReadKey();
        }

        public static void PrintCards(List<Card> cards)
        {                        
            foreach (Card card in cards)
                Console.WriteLine(card.Value.ToString() + " " + card.Suit.ToString());
            Console.WriteLine("\n");
        }       

    }
}
