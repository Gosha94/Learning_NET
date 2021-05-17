namespace CardWarGame.Interfaces.Card
{
    /// <summary>
    /// Интерфейс игровой сущности - карта
    /// </summary>
    interface ICard
    {
        
        /// <summary>
        /// Метод смены статуса карты (Рубашкой вверх либо открыта)
        /// </summary>
        void ChangeState();
    }
}
