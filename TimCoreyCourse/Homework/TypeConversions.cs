namespace TimCoreyCourse.Homework
{
    internal class TypeConversions
    {
        public static void Output()
        {
            Console.Write("How old are you? ");
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);
            int ageIn25Years = ageInt + 25;
            int age25YearsAgo = ageInt - 25;
            Console.WriteLine($"In 25 years you will be {ageIn25Years}");
            Console.WriteLine($"25 years ago you were {age25YearsAgo}");
        }
    }
}
