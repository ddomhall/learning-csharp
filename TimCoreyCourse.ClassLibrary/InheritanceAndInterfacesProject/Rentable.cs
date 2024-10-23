using TimCoreyCourse.ClassLibrary.Interfaces;

namespace TimCoreyCourse.ClassLibrary.InheritanceAndInterfacesProject
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
