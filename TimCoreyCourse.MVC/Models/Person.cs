using System.ComponentModel.DataAnnotations;

namespace TimCoreyCourse.MVC.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int? Age { get; set; }
    }
}
