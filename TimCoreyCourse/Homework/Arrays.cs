namespace TimCoreyCourse.Homework
{
    internal class Arrays
    {
        public static void Output()
        {
            string[] names = new string[] {"a", "b", "c"};
            bool valid = false;
            int num;

            do
            {
                Console.Write("enter a number: ");
                valid = int.TryParse(Console.ReadLine(), out num);
            }
            while (!valid || num < 1 || num > 3);

            Console.WriteLine(names[num - 1]);
        }
    }
}
