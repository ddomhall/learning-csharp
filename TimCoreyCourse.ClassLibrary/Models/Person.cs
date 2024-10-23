using TimCoreyCourse.ClassLibrary.Interfaces;

namespace TimCoreyCourse.ClassLibrary.Models
{
    public class Person : IRun
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Run()
        {
            Console.WriteLine("Person runs");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
