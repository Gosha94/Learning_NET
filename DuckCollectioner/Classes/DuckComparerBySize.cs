using System.Collections.Generic;

namespace DuckCollectioner.Classes
{
    class DuckComparerBySize : IComparer<Duck>
    {
        // Метод Compare() возвращает целое число и имеет два параметра, принадлежащих типу сортируемых объектов
        // Тип сравниваемых значений всегда будет совпадать
        public int Compare(Duck x, Duck y)
        {
            // Отрицательное число означает, что x должен стоять перед y, так как x «меньше, чем» y.
            if (x.Size < y.Size)
                return -1;
            // Положительное число означает, что x должен следовать за объектом y, так как x «больше» y.
            if (x.Size > y.Size)
                return 1;
            // Ноль означает совпадение размеров объектов.
            return 0;
        }
    }
}
