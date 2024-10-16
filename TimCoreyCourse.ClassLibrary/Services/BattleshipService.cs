using TimCoreyCourse.ClassLibrary.Models;

namespace TimCoreyCourse.ClassLibrary.Services
{
    public class BattleshipService
    {
        public static void DisplayBoard(BattleshipPlayer player)
        {
            Console.WriteLine(" |1|2|3|4|5");
            foreach (var letter in new string[] { "A", "B", "C", "D", "E" })
            {
                Console.WriteLine("-+-+-+-+-+-");
                Console.Write($"{letter}");
                foreach (var number in new int[] { 1, 2, 3, 4, 5 })
                {
                    Console.Write("|");
                    switch (player.Board[letter + number])
                    {
                        case BattleshipBoardStatus.Empty:
                            Console.Write(" ");
                            break;
                        case BattleshipBoardStatus.Ship:
                            Console.Write("#");
                            break;
                        case BattleshipBoardStatus.Miss:
                            Console.Write("O");
                            break;
                        case BattleshipBoardStatus.Hit:
                            Console.Write("X");
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
