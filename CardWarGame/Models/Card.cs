using CardWarGame.Enums;
using CardWarGame.Interfaces.Card;

namespace CardWarGame.Models
{
    /// <summary>
    /// Класс, определяющий карту из колоды
    /// </summary>
    public class Card : ICard
    {
        public CardFace FaceOfCard { get; private set; } = CardFace.Nothing;

        public CardSuit SuitOfCard { get; private set; } = CardSuit.None;

        public void ShowdownCard()
        {
            
        }
    }
}
