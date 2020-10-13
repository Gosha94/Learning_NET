using System;
using System.Collections.Generic;

namespace Go_Fish_408.Classes
{
    class CardComparerByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            //Если x имеет большее значение, метод возвращает 1.Если значение меньше, возвращается -1. Но оба оператора, возвращающие значение, завершают работу метода.
            if (x.Value < y.Value) return -1;
            if (x.Value > y.Value) return 1;           
            
            return 0;
        }
    }
}
