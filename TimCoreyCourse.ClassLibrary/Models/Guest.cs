namespace TimCoreyCourse.ClassLibrary.Models
{
    public class Guest
    {
        public Guest(string partyName, int partySize)
        {
            PartyName = partyName;
            PartySize = partySize;
        }

        public string PartyName { get; }
        public int PartySize { get; }
    }
}
