using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Go_Fish_408.Enums;

namespace Go_Fish_408.Classes
{
    class Deck
    {
            private List<Card> cards;
            private Random random = new Random();
            public Deck()
            {
                cards = new List<Card>();
                for (int suit = 0; suit <= 3; suit++)
                    for (int value = 1; value <= 13; value++)
                        cards.Add(new Card((Suits)suit, (Values)value));
            }
            public Deck(IEnumerable<Card> initialCards)
            {
                cards = new List<Card>(initialCards);
            }
            public int Count { get { return cards.Count; } }
            public void Add(Card cardToAdd)
            {
                cards.Add(cardToAdd);
            }
            public Card Deal(int index)
            {
                Card CardToDeal = cards[index];
                cards.RemoveAt(index);
                return CardToDeal;
            }
        public Card Deal()
        {
            return Deal(0);
        }

        public void Shuffle()
            {
                List<Card> NewCards = new List<Card>();
                while (cards.Count > 0)
                {
                    int CardToMove = random.Next(cards.Count);
                    NewCards.Add(cards[CardToMove]);
                    cards.RemoveAt(CardToMove);
                }
                cards = NewCards;
            }
            public IEnumerable<string> GetCardNames()
            {
                string[] CardNames = new string[cards.Count];
                for (int i = 0; i < cards.Count; i++)
                    CardNames[i] = cards[i].Name;
                return CardNames;
            }
            public void Sort()
            {
                cards.Sort(new CardComparerByValue());
            }
       
        // Метод ContainsValue() ищет в колоде карты определенного старшинства и, находя их, возвращает значение true.
        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
                if (card.Value == value)
                    return true;
            return false;
        }
        // Метод PullOutValues() позволяет получить наборы по четыре одинаковые карты.Он ищет карты, овпадающие по старшинству, извлекает их из колоды и возвращает новый вариант колоды, в который включена и взятка.
        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }
        // Метод HasBook(), получив в качестве параметра карту, начинает искать взятки. Обнаружив четыре одинаковыекарты, он возвращает значение True.
        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }
        // Метод SortByValue() сортирует колоду с помощью класса Comparer_byValue.
        public void SortByValue()
        {
            cards.Sort(new CardComparerByValue());
        }
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

    }
}
