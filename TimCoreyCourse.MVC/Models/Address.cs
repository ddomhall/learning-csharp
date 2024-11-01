using System.ComponentModel.DataAnnotations;

namespace TimCoreyCourse.MVC.Models
{
    public class Address
    {
        [Required]
        public int? HouseNumber { get; set; }

        [Required]
        public string PostCode { get; set; }
    }
}
