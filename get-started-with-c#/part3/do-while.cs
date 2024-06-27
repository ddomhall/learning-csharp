partial class Part3
{
	public static void doWhile()
	{

		/*
		Random random = new Random();
		int current = random.Next(1, 11);

		do
		{
			current = random.Next(1, 11);

			if (current >= 8) continue;

			Console.WriteLine(current);
		} while (current != 7);

		while (current >= 3)
		{
			Console.WriteLine(current);
			current = random.Next(1, 11);
		}
		Console.WriteLine($"Last number: {current}");

		// challenge

		Random attack = new();
		int hero = 10;
		int boss = 10;
		bool heroTurn = true;

		while (hero > 0 && boss > 0)
		{
			int hit = attack.Next(1, 11);
			if (heroTurn) boss -= hit; else hero -= hit;

			Console.WriteLine($"{(heroTurn ? "Boss" : "Hero")} was damaged and lost {hit} health and now has {(heroTurn ? boss : hero)} health.");
			heroTurn = !heroTurn;
		}

		Console.WriteLine(hero > 0 ? "Hero wins!" : "Boss wins!");

		// challenge

		int role = 0;
		string? readResult;

		Console.WriteLine("Enter an integer value between 5 and 10");
		do
		{
			readResult = Console.ReadLine();
			if (!int.TryParse(readResult, out role))
			{
				Console.WriteLine("Sorry, you entered an invalid number, please try again");
				continue;
			}
			role = int.Parse(readResult);
			if (role < 5 || role > 10)
			{
				Console.WriteLine($"You entered {role}. Please enter a number between 5 and 10.");
			}
		} while (role < 5 || role > 10);
		Console.WriteLine($"Your role value ({role}) has been accepted.");

		// challenge

		Console.WriteLine("Enter your role name(Administrator, Manager, or User)");
		string? role;
		bool valid = false;

		do
		{
			role = Console.ReadLine().Trim().ToLower();
			if (role == "administrator" || role == "manager" || role == "user") valid = true;
			else Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Enter your role name (Administrator, Manager, or User)");
		} while (valid == false);
		Console.WriteLine($"Your input value ({role}) has been accepted.");

		// challenge

		string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
		foreach (string myString in myStrings)
		{
			foreach (string sentence in myString.Split("."))
			{
				Console.WriteLine(sentence.Trim());
			}
		}
		*/

	}
}


