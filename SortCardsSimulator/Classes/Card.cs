using SortCardsSimulator.Enums;
using System.Collections.Generic;

namespace SortCardsSimulator.Classes
{
    class Card
    {
        // Enum Suit (Spades, Clubs, Diamonds, Hearts)
        public Suits Suit { get; set; }
        // Enum Value(Ace, Two, Three…Ten, Jack, Queen, King), а также
        public Values Value { get; set; }
        // только для чтения поле Name(Ace of Spades (туз пик), Five of Diamonds(пятерка бубен)
        public string Name { get { return Value.ToString() + " " + Suit.ToString(); } }
        // поле указывающее на то прошла ли сортировка списка        

        //public Card(Suits suit, Values value)
        //{
        //    this.Suit = suit;
        //    this.Value = value;
        //}
    }

}
