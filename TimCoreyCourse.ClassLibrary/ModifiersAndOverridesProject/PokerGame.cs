
namespace TimCoreyCourse.ClassLibrary.ModifiersAndOverridesProject
{
    public class PokerGame : CardGameBase
    {
        public override void DealCards()
        {
            foreach (CardGamePlayer player in players)
            {
                player.Hand.AddRange(DealCards(5));
            }
        }
    }
}
