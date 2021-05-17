namespace CardWarGame.Models
{
    class Player
    {
        /// <summary>
        /// Колода карт игрока
        /// </summary>
        public CardDeck playerDeck { get; set; }
        /// <summary>
        /// Выигранные битвы
        /// </summary>
        public int WinnedBattles { get; set; }


    }
}
