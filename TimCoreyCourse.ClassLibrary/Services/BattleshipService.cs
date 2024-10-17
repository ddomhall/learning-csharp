using TimCoreyCourse.ClassLibrary.Models;

namespace TimCoreyCourse.ClassLibrary.Services
{
    public class BattleshipService
    {
        public static int GetNumPlayers()
        {
            int numPlayers;
            string numPlayersText;

            do
            {
                Console.Clear();
                Console.Write("how many players: ");
                numPlayersText = Console.ReadLine();
            } while (!int.TryParse(numPlayersText, out numPlayers) || numPlayers == 0);

            return numPlayers;
        }

        public static List<BattleshipPlayer> CreatePlayers(int numPlayers)
        {
            List<BattleshipPlayer> players = new List<BattleshipPlayer>();

            for (int i = 0; i < numPlayers; i++)
            {
                string nameInput;
                do
                {
                    Console.Clear();
                    Console.Write($"player {i + 1} name: ");
                    nameInput = Console.ReadLine().Trim();
                } while (nameInput == "");

                players.Add(new BattleshipPlayer(nameInput));
            }

            return players;
        }

        private static void DisplayBoard(BattleshipPlayer player, bool enemy)
        {
            Console.WriteLine(" |1|2|3|4|5");
            foreach (var letter in new string[] { "A", "B", "C", "D", "E" })
            {
                Console.WriteLine("-+-+-+-+-+-");
                Console.Write($"{letter}");
                foreach (var number in new int[] { 1, 2, 3, 4, 5 })
                {
                    Console.Write("|");
                    BattleshipBoardStatus location = player.Board[letter + number];
                    if (location == BattleshipBoardStatus.Ship && !enemy)
                    {
                        Console.Write("#");
                    }
                    else if (location == BattleshipBoardStatus.Hit)
                    {
                        Console.Write("X");
                    }
                    else if (location == BattleshipBoardStatus.Miss)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void ResetBoard(BattleshipPlayer player)
        {
            foreach (var letter in new string[] { "A", "B", "C", "D", "E" })
            {
                foreach (var number in new int[] { 1, 2, 3, 4, 5 })
                {
                    player.Board[letter + number] = BattleshipBoardStatus.Empty;
                }
            }
        }

        public static bool ConfirmLocations(BattleshipPlayer player)
        {
            string confirmLocations;
            do
            {
                Console.Clear();
                Console.WriteLine($"{player.Name}'s ship placements\n");
                DisplayBoard(player, false);
                Console.Write("\nare you happy with these locations(y/n)? ");
                confirmLocations = Console.ReadLine().ToLower();
            } while (confirmLocations != "y" && confirmLocations != "n");

            return confirmLocations == "y";
        }

        public static void PlaceShips(List<BattleshipPlayer> players)
        {
            foreach(BattleshipPlayer player in players)
            {
                int placedShips = 0;
                string invalidPlacement = "";
                do
                {
                    Console.Clear();
                    Console.WriteLine($"{player.Name}'s ship placements\n");
                    DisplayBoard(player, false);

                    Console.Write($"\n{invalidPlacement}where do you want to put ship number {placedShips + 1}? ");

                    string locationInput = Console.ReadLine().ToUpper();
                    if (player.Board.ContainsKey(locationInput) && player.Board[locationInput] == BattleshipBoardStatus.Empty)
                    {
                        invalidPlacement = "";
                        player.Board[locationInput] = BattleshipBoardStatus.Ship;
                        placedShips++;

                        if (placedShips == 5 && !ConfirmLocations(player))
                        {
                            placedShips = 0;
                            ResetBoard(player);
                        }
                    }
                    else
                    {
                        invalidPlacement = $"\"{locationInput}\" is an invalid location, ";
                    }
                }
                while (placedShips < 5);
            }
        }

        public static int SelectPlayerToAttack(List<BattleshipPlayer> players, int currentPlayer)
        {
            int playerToAttack;

            do
            {
                Console.Clear();
                Console.WriteLine($"Player {currentPlayer + 1} attacking\n");

                for (int i = 0; i < players.Count; i++)
                {
                    if (i != currentPlayer) Console.WriteLine($"{i + 1} - {players[i].Name}");
                }

                Console.Write("\nselect the number for the player you want to attack: ");

                if (!int.TryParse(Console.ReadLine(), out playerToAttack)) continue;
                if (playerToAttack < 1 || playerToAttack > players.Count) continue;
                if (playerToAttack == currentPlayer + 1) continue;
                break;
            } while (true);

            return playerToAttack - 1;
        }
    }
}
