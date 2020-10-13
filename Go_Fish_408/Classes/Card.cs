using Go_Fish_408.Enums;
using Go_Fish_408.Classes;
using System.Collections.Generic;

namespace Go_Fish_408.Classes
{
    class Card
    {
        // Enum Suit (Spades, Clubs, Diamonds, Hearts)
        public Suits Suit { get; set; }
        // Enum Value(Ace, Two, Three…Ten, Jack, Queen, King), а также
        public Values Value { get; set; }
        // только для чтения поле Name
        public string Name { get { return Value.ToString() + " " + Suit.ToString(); } }
        public static string Plural(Values value)
        {
            if (value == Values.Шестерка)
                return "Sixes";
            else
                return value.ToString() + "s";
        }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }


    }

}
