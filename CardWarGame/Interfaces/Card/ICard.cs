using CardWarGame.Enums;

namespace CardWarGame.Interfaces.Card
{
    /// <summary>
    /// Интерфейс игровой сущности - карта
    /// </summary>
    interface ICard
    {
        /// <summary>
        /// Св-во для достоинства карты
        /// </summary>
        CardFace FaceOfCard { get; }

        /// <summary>
        /// Св-во для масти карты
        /// </summary>
        CardSuit SuitOfCard { get; }

        /// <summary>
        /// Метод вскрытия карты
        /// </summary>
        void ShowdownCard();
    }
}
