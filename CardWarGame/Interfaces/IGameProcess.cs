namespace CardWarGame.Interfaces
{
    /// <summary>
    /// Интерфейс определяет Игровой процесс
    /// </summary>
    interface IGameProcess
    {
        /// <summary>
        /// Битва, стандартная ситуация, когда игроки открывают одну свою карту по очереди
        /// </summary>
        void Battle();
        /// <summary>
        /// Война, ситуация, когда оба игрока вытаскивают одинаковые карты
        /// </summary>
        void War();
    }
}