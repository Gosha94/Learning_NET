using CardWarGame.Models;
using System;

namespace CardWarGame.Helper
{
    /// <summary>
    /// Универсальный класс-компаратор объектов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CardComparer<T> : IEquatable<T>
        where T: CardDeck, new()
    {
        bool IEquatable<T>.Equals(T other)
        {
            if (other.IsEmpty)
            {
                return false;
            }

            return
            object.ReferenceEquals(this.Name, other.Name) ||
            this != null &&
            this.Name.Equals(other.Name);
        }
    }
}
