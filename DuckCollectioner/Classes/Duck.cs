using System;
using DuckCollectioner.Enums;

namespace DuckCollectioner.Classes
{
    class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;
        // Чтобы получить ряд от самой маленькой до самой большой утки, метод CompareTo() должен возвращать положительное число при сравнении с уткой меньшего размера.
        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        private void Quack() { }
        private void Swim() { }
        private void Eat() { }
        private void Walk() { }
    }
}
