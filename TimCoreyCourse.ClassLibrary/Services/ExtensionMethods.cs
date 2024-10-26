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
    }
}
