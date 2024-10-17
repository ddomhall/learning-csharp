namespace TimCoreyCourse.ClassLibrary.Models
{
    public class BattleshipPlayer
    {
        public BattleshipPlayer(string name)
        {
            Name = name;
            Active = true;
            Board = new Dictionary<string, BattleshipBoardStatus>();
            foreach (var letter in new string[] { "A", "B", "C", "D", "E" })
            {
                foreach (var number in new int[] { 1, 2, 3, 4, 5 })
                {
                    Board.Add(letter + number, BattleshipBoardStatus.Empty);
                }
            }
        }
        public string Name { get; }
        public bool Active { get; set; }
        public Dictionary<string, BattleshipBoardStatus> Board { get; set; }
    }
}
