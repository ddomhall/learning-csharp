using TimCoreyCourse.ClassLibrary.Services;
using TimCoreyCourse.ClassLibrary.Models;
using TimCoreyCourse.ClassLibrary.Namespaces;
using TimCoreyCourse.ClassLibrary.Battleships;
using TimCoreyCourse.ClassLibrary.Inheritance;

namespace TimCoreyCourse
{
    public class Homework
    {
        public static void Variables()
        {
            string name = "dom";
            int age = 22;
            bool alive = true;
            string countryCode = "+44";
            decimal phoneNumber = 7777777777;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Alive: {alive}");
            Console.WriteLine($"Number: {countryCode} {phoneNumber}");
        }

        public static void TypeConversions()
        {
            Console.Write("How old are you? ");
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);
            int ageIn25Years = ageInt + 25;
            int age25YearsAgo = ageInt - 25;
            Console.WriteLine($"In 25 years you will be {ageIn25Years}");
            Console.WriteLine($"25 years ago you were {age25YearsAgo}");
        }

        public static void ConditionalStatements()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "tim")
            {
                Console.WriteLine("Welcome, professor");
            }
            else
            {
                Console.WriteLine("Welcome, student");
            }
        }

        public static void StudentCheck()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            if (name.ToLower() == "bob" || name.ToLower() == "sue")
            {
                Console.WriteLine("Hi, Professor");
            }
            else
            {
                if (age < 21)
                {
                    Console.WriteLine($"Come back in {21 - age} years");
                }
                else
                {
                    Console.WriteLine("Welcome");
                }
            }
        }

        public static void DoLoops()
        {
            string name;

            do
            {
                Console.Write("name: ");
                name = Console.ReadLine();

                switch (name.ToLower())
                {
                    case "exit":
                        break;
                    case "tim":
                        Console.WriteLine("Welcome, professor");
                        break;
                    default:
                        Console.WriteLine("Welcome, student");
                        break;
                }
            }
            while (name.ToLower() != "exit");
        }

        public static void Arrays()
        {
            string[] names = new string[] { "a", "b", "c" };
            bool valid = false;
            int num;

            do
            {
                Console.Write("enter a number: ");
                valid = int.TryParse(Console.ReadLine(), out num);
            }
            while (!valid || num < 1 || num > 3);

            Console.WriteLine(names[num - 1]);
        }

        public static void Lists()
        {
            List<string> roster = new List<string>();
            string input;
            do
            {
                Console.Write("enter student name: ");
                input = Console.ReadLine();
                if (input != "")
                {
                    roster.Add(input);
                }
            }
            while (input != "");
            Console.WriteLine(roster.Count());
        }

        public static void Dictionaries()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();

            Console.Write("enter name 1: ");
            names[1] = Console.ReadLine();

            Console.Write("enter name 2: ");
            names[2] = Console.ReadLine();

            Console.Write("enter name 3: ");
            names[3] = Console.ReadLine();

            bool valid;
            int id;

            do
            {
                Console.Write("which name do you want? ");
                valid = int.TryParse(Console.ReadLine(), out id);
            }
            while (!valid || id < 1 || id > 3);
            Console.WriteLine(names[id]);
        }

        public static void ForLoops()
        {
            Console.Write("Enter names: ");
            List<string> names = Console.ReadLine().Split(',').ToList();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i]}");
            }
        }

        public static void ForEachLoops()
        {
            string input;
            List<string> names = new List<string>();

            do
            {
                Console.Write("enter name: ");
                input = Console.ReadLine();
                if (input != "") names.Add(input);
            } while (input != "");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name}");
            }
        }

        public static void Methods()
        {
            void WelcomeUser()
            {
                Console.WriteLine("Welcome");
            }

            string GetName()
            {
                Console.Write("name: ");
                return Console.ReadLine();
            }

            void GreetUser(string name)
            {
                Console.WriteLine($"Hello {name}");
            }

            WelcomeUser();
            string name = GetName();
            GreetUser(name);
        }

        public static void GuestBook()
        {
            Dictionary<string, int> guestBook = new Dictionary<string, int>();

            do
            {
                guestBook[GetName()] = GetGuests();
            }
            while (AnotherGuest());

            DisplayNamesAndTotal();

            string GetName()
            {
                string name = "";

                do
                {
                    Console.Write("name: ");
                    name = Console.ReadLine();
                } while (name == "" || guestBook.ContainsKey(name));

                return name;
            }

            int GetGuests()
            {
                string numGuestsText;
                int numGuests;

                do
                {
                    Console.Write("guests: ");
                    numGuestsText = Console.ReadLine();
                }
                while (!int.TryParse(numGuestsText, out numGuests));

                return numGuests;
            }

            bool AnotherGuest()
            {
                string anotherGuest;

                do
                {
                    Console.Write("add another guest? ");
                    anotherGuest = Console.ReadLine();
                } while (anotherGuest.ToLower() != "y" && anotherGuest.ToLower() != "n");

                return anotherGuest == "y";
            }

            void DisplayNamesAndTotal()
            {
                Console.WriteLine("\nGroups:");
                int total = 0;

                foreach (var guest in guestBook)
                {
                    Console.WriteLine(guest.Key);
                    total += guest.Value;
                }

                Console.WriteLine($"\nGuests: {total}");
            }
        }

        public static void Breakpoints()
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += i * 5;
            }
        }

        public static void Exceptions()
        {
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 5) throw new Exception("5 iterations");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AdvancedExceptions()
        {
            try
            {
                BadFunction();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            void BadFunction()
            {
                throw new Exception("bad function");
            }
        }

        public static void AdvancedBreakpoints()
        {
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i == 73) throw new Exception("iteration 73");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void StaticClasses()
        {
            CalculationService.Add(10, 10);
            CalculationService.Subtract(10, 10);
            CalculationService.Multiply(10, 10);
            CalculationService.Divide(10, 10);
        }

        public static void InstantiatedClasses()
        {
            Person person = new Person();
            person.Name = "name";

            Address address = new Address();
            address.PostCode = "postcode";

            Console.WriteLine($"{person.Name} lives at {address.PostCode}");
        }

        public static void PropertyTypes()
        {
            Address address = new Address();
            address.HouseNumber = 1;
            address.Street = "street";
            address.PostCode = "postcode";

            Console.WriteLine(address.FullAddress);
        }

        public static void Namespaces()
        {
            DifferentNamespace differentNamespace = new DifferentNamespace("different namespace");
            Console.WriteLine(differentNamespace.Name);
        }

        public static void ClassLibraries()
        {
            Person person = new Person();
            person.Name = "name";
            person.Age = 0;

            Console.WriteLine($"{person.Name} is {person.Age}");
        }

        public static void GuestBookV2()
        {
            List<Guest> guests = new List<Guest>();

            do
            {
                guests.Add(new Guest(GetPartyName(), GetPartySize()));
            } while (MoreGuests());

            DisplayGuestInfo();

            string GetPartyName()
            {
                string partyName = "";
                do
                {
                    Console.Write("Party name: ");
                    partyName = Console.ReadLine();
                } while (partyName == "");

                return partyName;
            }

            int GetPartySize()
            {
                int partySize;
                string partySizeText;

                do
                {
                    Console.Write("Party size: ");
                    partySizeText = Console.ReadLine();
                } while (!int.TryParse(partySizeText, out partySize));

                return partySize;
            }

            bool MoreGuests()
            {
                string moreGuests;

                do
                {
                    Console.Write("More guests? ");
                    moreGuests = Console.ReadLine();
                } while (moreGuests != "y" && moreGuests != "n");

                return moreGuests == "y";
            }

            void DisplayGuestInfo()
            {
                int total = 0;
                Console.WriteLine("\nParty names:");

                foreach (Guest guest in guests)
                {
                    Console.WriteLine(guest.PartyName);
                    total += guest.PartySize;
                }

                Console.Write($"\nTotal guests: {total}\n");
            }
        }

        public static void BattleshipApp()
        {
            int numPlayers = BattleshipService.GetNumPlayers();
            List<BattleshipPlayer> players = BattleshipService.CreatePlayers(numPlayers);
            BattleshipService.PlaceShips(players);

            do
            {
                BattleshipPlayer playerToAttack = BattleshipService.SelectPlayerToAttack(players);
                BattleshipService.AttackPlayer(playerToAttack);
                BattleshipService.CheckActive(players, playerToAttack);

                if (players.Count() == 1) break;
                else BattleshipService.UpdatePlayerTurn(players);
            } while (true);

            Console.WriteLine($"{players[0].Name} wins");
        }

        public static void Inheritance()
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            Boat boat = new Boat();
            Motorcycle motorcycle = new Motorcycle();

            Console.WriteLine(vehicle.VehicleProp);

            Console.WriteLine(car.VehicleProp);
            Console.WriteLine(car.CarProp);

            Console.WriteLine(boat.VehicleProp);
            Console.WriteLine(boat.BoatProp);

            Console.WriteLine(motorcycle.VehicleProp);
            Console.WriteLine(motorcycle.MotorcycleProp);
        }

        public static void Interfaces()
        {
            Person person = new Person();
            Animal animal = new Animal();
            person.Run();
            animal.Run();
        }
    }
}
