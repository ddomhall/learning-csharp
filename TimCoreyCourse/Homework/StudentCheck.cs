namespace TimCoreyCourse.Homework
{
    internal class StudentCheck
    {
        public static void Output()
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
    }
}
