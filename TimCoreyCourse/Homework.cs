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
            string[] names = new string[] {"a", "b", "c"};
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

    }
}
