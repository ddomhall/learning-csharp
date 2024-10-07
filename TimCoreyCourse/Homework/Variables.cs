namespace TimCoreyCourse.Homework
{
    internal class Variables
    {
        static string name = "dom";
        static int age = 22;
        static bool alive = true;
        static string countryCode = "+44";
        static decimal phoneNumber = 7777777777;

        public static void Output()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Alive: {alive}");
            Console.WriteLine($"Number: {countryCode} {phoneNumber}");
        }
    }
}
