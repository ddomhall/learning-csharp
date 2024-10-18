using TimCoreyCourse.ClassLibrary.Interfaces;

namespace TimCoreyCourse.ClassLibrary.Models
{
    public class Animal : IRun
    {
        public void Run()
        {
            Console.WriteLine("Animal runs");
        }
    }
}
