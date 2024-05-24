string x = "";
while (!Int32.TryParse(x, out int b))
{
    Console.WriteLine("Enter number 1:");
    x = Console.ReadLine();
}
Console.WriteLine(x);
