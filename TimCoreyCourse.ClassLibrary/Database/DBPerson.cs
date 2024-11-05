using System.IO.Pipes;

namespace TimCoreyCourse.ClassLibrary.Database
{
    public class DBPerson
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int EmployerId { get; set; }
        public string Name { get; set; }
    }
}
