using System.Collections.Generic;

namespace CardWarGame.Models
{
    /// <summary>
    /// Класс представляет колоду карт игрока
    /// </summary>
    class CardDeck
    {
        /// <summary>
        /// Пуста ли колода игрока
        /// </summary>
        public bool IsEmpty { get; set; } = true;

        /// <summary>
        /// Список из карт в колоде
        /// </summary>
        public List<Card> Cards { get; set; }
    }
}
