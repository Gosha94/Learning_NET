using System;
using System.Collections.Generic;

namespace SortCardsSimulator.Classes
{
    class CardComparerValueThenSuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            //Если x имеет большее значение, метод возвращает 1.Если значение меньше, возвращается -1. Но оба оператора, возвращающие значение, завершают работу метода.
            if (x.Value < y.Value) return -1;
            if (x.Value > y.Value) return 1;
            
            // Эти операторы ниже выполняются только при совпадении значений x и y, ведь первые два оператора, возвращающие значение, в этом случае не выполняются.
            if (x.Suit < y.Suit) return -1;
            if (x.Suit > y.Suit) return 1;
            return 0;
        }
    }
}
