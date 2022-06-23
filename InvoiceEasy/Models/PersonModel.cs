namespace InvoiceEasy.Models
{
    public class PersonModel
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string? address { get; set; }
        public CompanyModel? company { get; set; } = null;
        public int phoneNumber { get; set; }
        public bool isActive { get; set; }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
