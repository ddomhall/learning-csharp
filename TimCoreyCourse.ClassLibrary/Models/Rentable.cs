using TimCoreyCourse.ClassLibrary.Interfaces;

namespace TimCoreyCourse.ClassLibrary.Models
{
    public class Rentable : NamedItem, IRentable
    {
        public Rentable(string name)
        {
            Name = name;
        }

        public void Rent()
        {
            Console.WriteLine($"renting {Name}");
        }
    }
}
