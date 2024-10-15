namespace TimCoreyCourse.ClassLibrary.Models
{
    public class Address
    {
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string FullAddress
        {
            get
            {
                return $"{HouseNumber} {Street}, {PostCode}";
            }
        }
    }
}
