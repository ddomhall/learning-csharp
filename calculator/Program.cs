using System.Text.RegularExpressions;

string input = "";
while (!Regex.IsMatch(input, @"^\d+(\.\d+)?(\+|\-|\*|\/)\d+(\.\d+)?$"))
{
    Console.WriteLine("Enter calculation:");
    input = Console.ReadLine()!;
}
Console.Write(input + "=");

string[] calculation = Regex.Split(input, @"(\+|\-|\*|\/)");
decimal a = Decimal.Parse(calculation[0]);
decimal b = Decimal.Parse(calculation[2]);

switch (calculation[1])
{
    case "+":
        Console.WriteLine(a + b);
        break;
    case "-":
        Console.WriteLine(a - b);
        break;
    case "*":
        Console.WriteLine(a * b);
        break;
    case "/":
        Console.WriteLine(a / b);
        break;
}

