string? x = "";
string? y = "";
string? z = "";
string[] operations = ["+", "-", "*", "/"];

while (!Int32.TryParse(x, out int fallback))
{
    Console.WriteLine("Enter number 1:");
    x = Console.ReadLine();
}

while (!operations.Contains(y))
{
    Console.WriteLine("Select operation (+ - * /):");
    y = Console.ReadLine();
}

while (!Int32.TryParse(z, out int fallback))
{
    Console.WriteLine("Enter number 2:");
    z = Console.ReadLine();
}

Console.Write(x + y + z + "=");

int a = Int32.Parse(x);
int b = Int32.Parse(z);

switch (y)
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
