using TimCoreyCourse.ClassLibrary.Interfaces;

namespace TimCoreyCourse.ClassLibrary.Models
{
    public class BuyAndRentable : NamedItem, IBuyable, IRentable
    {
        public BuyAndRentable(string name)
        {
            Name = name;
        }

        public void Buy()
        {
            Console.WriteLine("buying BuyAndRentable");
        }

        public void Rent()
        {
            Console.WriteLine($"renting {Name}");
        }
    }
}
