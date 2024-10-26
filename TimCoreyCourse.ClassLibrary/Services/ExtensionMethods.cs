using TimCoreyCourse.ClassLibrary.Models;

namespace TimCoreyCourse.ClassLibrary.Services
{
    public static class ExtensionMethods
    {
        public static Person SetDefaultAge(this Person person)
        {
            person.Age = 100;
            return person;
        }

        public static void PrintInfo(this Person person)
        {
            Console.WriteLine($"{person.Name} is {person.Age}");
        }

        public static decimal Update(this decimal decimalValue, string message)
        {
            string decimalValueText;
            do
            {
                Console.Write($"{message} ");
                decimalValueText = Console.ReadLine();
            }
            while (!decimal.TryParse(decimalValueText, out decimalValue));
            return decimalValue;
        }

        public static string Update(this string stringValue, string message)
        {
            do
            {
                Console.Write($"{message} ");
                stringValue = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(stringValue));
            return stringValue;
        }
    }
}
