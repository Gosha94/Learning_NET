using CardWarGame.Enums;
using CardWarGame.Interfaces.Card;
using System;

namespace CardWarGame.Helper
{
    /// <summary>
    /// Универсальный класс-компаратор объектов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CardComparer<T> : IEquatable<T>, ICard
        where T: ICard, new()
    {

        #region Implemented Shit

        public CardFace FaceOfCard { get; }

        public CardSuit SuitOfCard { get; }

        void ICard.ShowdownCard()
        {
            throw new NotImplementedException();
        }

        #endregion

        public bool Equals(T other)
        {
            if (other == null)
            {
                return false;
            }

            // Для ссылочного типа следует использовать ReferenceEquals, значимого - Equals
            return
                this.FaceOfCard.Equals(other.FaceOfCard)
                &&
                this.SuitOfCard.Equals(other.SuitOfCard);
        }        
    }
}
