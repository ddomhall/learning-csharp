namespace TimCoreyCourse.Homework
{
    internal class DoLoops
    {
        public static void Output()
        {
            string name;

            do
            {
                Console.Write("name: ");
                name = Console.ReadLine();

                switch (name.ToLower())
                {
                    case "exit":
                        break;
                    case "tim":
                        Console.WriteLine("Welcome, professor");
                        break;
                    default:
                        Console.WriteLine("Welcome, student");
                        break;
                }
            }
            while (name.ToLower() != "exit");
        }
    }
}
