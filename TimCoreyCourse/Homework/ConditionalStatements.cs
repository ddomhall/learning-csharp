namespace TimCoreyCourse.Homework
{
    internal class ConditionalStatements
    {
        public static void Output()
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
    }
}
