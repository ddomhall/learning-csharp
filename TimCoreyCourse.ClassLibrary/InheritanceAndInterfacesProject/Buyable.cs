using TimCoreyCourse.ClassLibrary.Interfaces;

namespace TimCoreyCourse.ClassLibrary.InheritanceAndInterfacesProject
{
    public class Buyable : NamedItem, IBuyable
    {
        public Buyable(string name)
        {
            Name = name;
        }

        public void Buy()
        {
            Console.WriteLine($"buying {Name}");
        }
    }
}
