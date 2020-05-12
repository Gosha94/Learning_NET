using AceOfSpades_Game.Enums;

namespace AceOfSpades_Game
{
    class Card
    {
        // Enum Suit (Spades, Clubs, Diamonds, Hearts)
        public Suits Suit { get; set; }
        // Enum Value(Ace, Two, Three…Ten, Jack, Queen, King), а также
        public Values Value { get; set; }
        // только для чтения поле Name(Ace of Spades (туз пик), Five of Diamonds(пятерка бубен)
        public string Name { get { return Value.ToString() + " " + Suit.ToString(); } }
        
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
