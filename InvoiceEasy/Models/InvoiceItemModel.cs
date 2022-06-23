namespace InvoiceEasy.Models
{
    public class InvoiceItemModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public decimal cost { get; set; }
        public bool isActive { get; set; }
    }
}
