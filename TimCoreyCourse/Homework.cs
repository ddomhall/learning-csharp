﻿using TimCoreyCourse.ClassLibrary.Services;
using TimCoreyCourse.ClassLibrary.Models;
using TimCoreyCourse.ClassLibrary.Namespaces;
using TimCoreyCourse.ClassLibrary.Battleships;
using TimCoreyCourse.ClassLibrary.Inheritance;
using TimCoreyCourse.ClassLibrary.Interfaces;
using TimCoreyCourse.ClassLibrary.AccessModifiers;
using TimCoreyCourse.ClassLibrary.InheritanceAndInterfacesProject;
using TimCoreyCourse.ClassLibrary.AbstractClasses;
using TimCoreyCourse.ClassLibrary.ModifiersAndOverridesProject;
using TimCoreyCourse.ClassLibrary.Database;
using TimCoreyCourse.ClassLibrary.API;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace TimCoreyCourse
{
    public class Homework
    {
        public static void Start()
        {
            Console.WriteLine("Tim Corey Course\n");
        }

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
            Console.WriteLine(CalculationService.Add(10, 10));
            Console.WriteLine(CalculationService.Subtract(10, 10));
            Console.WriteLine(CalculationService.Multiply(10, 10));
            Console.WriteLine(CalculationService.Divide(10, 10));
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

        public static void InheritanceAndInterfacesProject()
        {
            List<IRentable> rentables = new List<IRentable>();
            List<IBuyable> buyables = new List<IBuyable>();

            rentables.Add(new Rentable("Rentable"));
            rentables.Add(new BuyAndRentable("BuyAndRentable"));

            buyables.Add(new Buyable("Buyable"));
            buyables.Add(new BuyAndRentable("BuyAndRentable"));

            foreach (IRentable item in rentables)
            {
                item.Rent();
            }

            foreach (IBuyable item in buyables)
            {
                item.Buy();
            }
        }

        public static void AccessModifiers()
        {
            AccessModifierTest accessModifierTest = new AccessModifierTest();
            accessModifierTest.Public = true;
            accessModifierTest.Private = true;

            AccessModifierInterface accessModifierInterface = new AccessModifierInterface();
            accessModifierInterface.Protected = true;
            accessModifierInterface.Internal = true;
        }

        public static void AbstractClasses()
        {
            IAbstractInterface child = new AbstractChild();
            child.AbstractInterfaceMethod();
        }

        public static void MethodOverriding()
        {
            Person person = new Person();
            person.Name = "test";
            Console.WriteLine(person);
        }

        public static void ModifiersAndOverridesProject()
        {
            //PokerGame game = new PokerGame();
            BlackjackGame game = new BlackjackGame();

            game.CreatePlayers();
            game.DealCards();
            game.RevealCards();
        }

        public static void MethodOverloading()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(),
                new Employee("dom2"),
                new Employee("dom3", "ddomhall2"),
            };

            foreach (Employee employee in employees)
            {
                employee.DisplayNameAndCompany();
            }
        }

        public static void ExtensionMethods()
        {
            Person person = new Person("dom");
            person.SetDefaultAge().PrintInfo();
        }

        public static void OverloadingAndExtensionsProject()
        {
            Buyer buyer = new Buyer();
            buyer.LastBoughtItem = buyer.LastBoughtItem.Update("what is the last item you bought?");
            buyer.LastBoughtItemCost = buyer.LastBoughtItemCost.Update("how much did it cost?");
            Console.WriteLine($"your {buyer.LastBoughtItem} cost {buyer.LastBoughtItemCost}");
        }

        public static void Generics()
        {
            void PrintToString<T>(T item)
            {
                Console.WriteLine(item.ToString());
            }

            PrintToString("test");
            PrintToString(0);
            PrintToString(true);
        }

        public static void Events()
        {
            EventTest eventTest = new EventTest();
            eventTest.Event += EventListener;
            eventTest.TriggerEvent();

            void EventListener(object? sender, string e)
            {
                Console.WriteLine(e);
            }
        }

        public static void GenericsAndEventsProject()
        {
            List<Person> people = new List<Person>()
            {
                new Person("dom1"),
                new Person("dom2"),
                new Person("dom3"),
            };

            CSVConverter<Person> personConverter = new CSVConverter<Person>();
            personConverter.NameContains1 += PersonConverter_NameContains1;
            personConverter.OutputAsCSV(people);

            void PersonConverter_NameContains1(object? sender, Person e)
            {
                Console.WriteLine($"{e.Name} contains 1");
            }
        }

        public static void Database()
        {
            DataAccess sql = new DataAccess(GetConnectionString());

            var people = sql.GetAllPeople();
            foreach (var personId in people)
            {
                var person = sql.GetFullPersonById(personId.Id);
                Console.WriteLine($"{person.Id}: {person.Name}, {person.Address}, {person.Employer}");
            }


            string GetConnectionString(string connStrName = "Default")
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

                var config = builder.Build();

                return config.GetConnectionString(connStrName);
            }
        }

        public static void TextFiles()
        {
            List<Person> people1 = new List<Person>()
            {
                new Person()
                {
                    Name = "dom1",
                    Age = 1
                },

                new Person()
                {
                    Name = "dom2",
                    Age = 2
                }
            };

            List<string> csv = new List<string>();
            foreach (var person in people1)
            {
                csv.Add($"{person.Name},{person.Age}");
            }
            string filePath = "C:\\Users\\domjs\\Desktop\\test.csv";

            File.WriteAllLines(filePath, csv);
            List<string> readLines = File.ReadAllLines(filePath).ToList();

            List<Person> people2 = new List<Person>();
            foreach (var readLine in readLines)
            {
                string[] line = readLine.Split(',');
                people2.Add(new Person()
                {
                    Name = line[0],
                    Age = int.Parse(line[1])
                });
            }

            foreach (var person in people2)
            {
                Console.WriteLine($"{person.Name},{person.Age}");
            }
        }

        public static async void APIs()
        {
            var client = new HttpClient();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var response = client.GetAsync("https://swapi.dev/api/people/1");
            if (response.Result.IsSuccessStatusCode)
            {
                var data = await response.Result.Content.ReadAsStringAsync();
                var swPerson = JsonSerializer.Deserialize<SWPerson>(data, options);
                Console.WriteLine(swPerson.Name);

                List<SWFilm> films = new List<SWFilm>();
                foreach (var film in swPerson.Films)
                {
                    response = client.GetAsync(film);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        data = await response.Result.Content.ReadAsStringAsync();
                        var swFilm = JsonSerializer.Deserialize<SWFilm>(data, options);
                        Console.WriteLine(swFilm.Title);
                        films.Add(swFilm);
                    }
                }
            }
        }

        public static void LinqAndLambdas()
        {
            List<Person> people = new List<Person>()
            {
                new Person() {Name = "dom1", Age = 1},
                new Person() {Name = "dom2", Age = 2},
                new Person() {Name = "dom3", Age = 3},
                new Person() {Name = "dom4", Age = 4},
                new Person() {Name = "dom5", Age = 5},
            };

            List<Person> results1 = people.Where(x => x.Age > 2).OrderBy(x => x.Age).ToList();
            List<Person> results2 = (from p in people where p.Age < 3 orderby p.Age descending select p).ToList();

            Console.WriteLine("res1");
            foreach (Person person in results1) Console.WriteLine($"{person.Name} is {person.Age}");

            Console.WriteLine("\nres2");
            foreach (Person person in results2) Console.WriteLine($"{person.Name} is {person.Age}");
        }
    }
}
