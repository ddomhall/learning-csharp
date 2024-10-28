using System.Drawing;

namespace TimCoreyCourse.ClassLibrary.Models
{
    public class Employee
    {
        private string Name { get; set; }

        private string Company { get; set; }

        public Employee()
        {
            SetNameAndCompany("dom", "ddomhall");
        }

        public Employee(string name)
        {
            SetNameAndCompany(name, "ddomhall");
        }

        public Employee(string name, string company)
        {
            SetNameAndCompany(name, company);
        }

        private void SetNameAndCompany(string name, string company)
        {
            Name = name;
            Company = company;
        }

        public void DisplayNameAndCompany()
        {
            Console.WriteLine($"{Name}, {Company}");
        }
    }
}
