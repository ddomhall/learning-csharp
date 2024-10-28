namespace TimCoreyCourse.ClassLibrary.ModifiersAndOverridesProject
{
    public class CardGamePlayer
    {
        public int Id { get; set; }
        public List<PlayingCard> Hand {  get; set; } = new List<PlayingCard>();
    }
}
