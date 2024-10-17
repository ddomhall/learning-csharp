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
            } while (!int.TryParse(numPlayersText, out numPlayers) || numPlayers < 2);

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

                players.Add(new BattleshipPlayer(nameInput, i));
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
            foreach (BattleshipPlayer player in players)
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

        public static BattleshipPlayer SelectPlayerToAttack(List<BattleshipPlayer> players)
        {
            BattleshipPlayer playerToAttack;
            BattleshipPlayer playerAttacking = players.Find(x => x.IsPlayerTurn);

            if (players.Count == 2) return players.Find(x => x != playerAttacking);

            do
            {
                Console.Clear();
                Console.WriteLine($"{playerAttacking.Name} attacking");

                foreach (BattleshipPlayer player in players)
                {
                    if (!player.IsPlayerTurn)
                    {
                        Console.WriteLine($"\n{player.Id + 1} - {player.Name}");
                        DisplayBoard(player, true);
                    }
                }

                Console.Write("\nselect the number for the player you want to attack: ");

                if (!int.TryParse(Console.ReadLine(), out int playerToAttackId)) continue;
                playerToAttack = players.Find(x => x.Id == playerToAttackId - 1);
                if (playerToAttack == null || playerToAttack.IsPlayerTurn) continue;
                break;
            } while (true);

            return playerToAttack;
        }

        public static void AttackPlayer(BattleshipPlayer player)
        {
            string locationInput;
            string invalidLocation = "";
            do
            {
                Console.Clear();
                Console.WriteLine($"attacking {player.Name}\n");
                DisplayBoard(player, true);

                Console.Write($"\n{invalidLocation}enter location to attack: ");
                locationInput = Console.ReadLine().ToUpper();

                try
                {
                    switch (player.Board[locationInput])
                    {
                        case BattleshipBoardStatus.Empty:
                            player.Board[locationInput] = BattleshipBoardStatus.Miss;
                            Console.WriteLine(@"
        ------               _____
       /      \ ___\     ___/    ___
    --/-  ___  /    \/  /  /    /   \
   /     /           \__     //_     \
  /                     \   / ___     |
  |           ___       \/+--/        /
   \__           \       \           /
      \__                 |          /
     \     /____      /  /       |   /
      _____/         ___       \/  /\
           \__      /      /    |    |
         /    \____/   \       /   //
     // / / // / /\    /-_-/\//-__-
      /  /  // /   \__// / / /  //
     //   / /   //   /  // / // /
      /// // / /   /  //  / //
   //   //       //  /  // / /
     / / / / /     /  /    /
  ///  / / /  //  // /  // //
     ///    /    /    / / / /
///  /    // / /  // / / /  /
   // ///   /      /// / /");
                            break;
                        case BattleshipBoardStatus.Ship:
                            player.Board[locationInput] = BattleshipBoardStatus.Hit;
                            Console.WriteLine(@"
     _.-^^---....,,--
 _--                  --_
<                        >)
|                         |
 \._                   _./
    ```--. . , ; .--'''
          | |   |
       .-=||  | |=-.
       `-=#$%&%$#=-'
          | ;  :|
 _____.,-#%&$@%#&#~,._____");
                            break;
                        default:
                            throw new Exception();
                    }
                    Thread.Sleep(1000);
                    break;
                }
                catch (Exception)
                {
                    invalidLocation = $"\"{locationInput}\" is an invalid location, ";
                    continue;
                }
            }
            while (true);
        }

        public static void CheckActive(List<BattleshipPlayer> players, BattleshipPlayer playerToCheck)
        {
            int total = 0;
            foreach (var letter in new string[] { "A", "B", "C", "D", "E" })
            {
                foreach (var number in new int[] { 1, 2, 3, 4, 5 })
                {
                    if (playerToCheck.Board[letter + number] == BattleshipBoardStatus.Hit) total++;
                }
            }
            if (total == 5)
            {
                players.Remove(playerToCheck);
                Console.Clear();
                Console.WriteLine(@"
                            ,--.
                           {    }
                           K,   }
                          /  ~Y`
                     ,   /   /
                    {_'-K.__/
                      `/-.__L._
                      /  ' /`\_}
                     /  ' /
             ____   /  ' /
      ,-'~~~~    ~~/  ' /_
    ,'             ``~~~  ',
   (                        Y
  {                         I
 {      -                    `,
 |       ',                   )
 |        |   ,..__      __. Y
 |    .,_./  Y ' / ^Y   J   )|
 \           |' /   |   |   ||
  \          L_/    . _ (_,.'(
   \,   ,      ^^""' / |      )
     \_  \          /,L]     /
       '-_~-,       ` `   ./`
          `'{_            )
              ^^\..___,.--`");
                Thread.Sleep(1000);
            }
        }

        public static void UpdatePlayerTurn(List<BattleshipPlayer> players)
        {
            BattleshipPlayer currentPlayer = players.Find(x => x.IsPlayerTurn);
            int currentPlayerIndex = players.IndexOf(currentPlayer);
            currentPlayer.IsPlayerTurn = false;
            players[(currentPlayerIndex + 1) % players.Count].IsPlayerTurn = true;
        }
    }
}
