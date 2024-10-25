namespace TimCoreyCourse.ClassLibrary.ModifiersAndOverridesProject
{
    public abstract class CardGameBase
    {
        protected List<PlayingCard> drawPile = new List<PlayingCard>();
        protected List<PlayingCard> discardPile = new List<PlayingCard>();
        public List<CardGamePlayer> players = new List<CardGamePlayer>();

        protected CardGameBase()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 0; value < 13; value++)
                {
                    drawPile.Add(new PlayingCard { Suit = (CardSuit)suit, Value = (CardValue)value });
                    ShuffleDeck();
                }
            }
        }

        private void ShuffleDeck()
        {
            drawPile = drawPile.OrderBy(x => new Random().Next()).ToList();
        }

        private void RestockDeck()
        {
            drawPile.AddRange(discardPile);
            ShuffleDeck();
        }

        protected List<PlayingCard> DealCards(int count)
        {
            if (count > drawPile.Count) RestockDeck();
            var output = drawPile.Take(count).ToList();
            foreach (var card in output) drawPile.Remove(card);
            return output;
        }

        protected void ReturnCards(List<PlayingCard> cards)
        {
            discardPile.AddRange(cards);
        }

        public void CreatePlayers()
        {
            string numPlayersText;
            int numPlayers;
            do
            {
                Console.Write("how many players? ");
                numPlayersText = Console.ReadLine();
            } while (!int.TryParse(numPlayersText, out numPlayers));

            for (int i = 0; i < numPlayers; i++) players.Add(new CardGamePlayer { Id = i });
        }

        public void RevealCards()
        {
            Console.Clear();
            foreach (CardGamePlayer player in players)
            {
                Console.WriteLine($"player {player.Id + 1}");
                foreach (PlayingCard card in player.Hand)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }
                Console.WriteLine();
            }
        }

        public abstract void DealCards();
    }
}
