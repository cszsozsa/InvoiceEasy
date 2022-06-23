namespace InvoiceEasy.Models
{
    public class InvoiceModel
    {
        public int id { get; set; }
        public int uniqueNumber { get; set; }
        public PersonModel seller { get; set; }
        public PersonModel buyer { get; set; }
        public DateTime issueDate { get; set; }
        public DateTime paymentDate { get; set; }
        public DateTime deliveryDate { get; set; }
        public string paymentMethod { get; set; }
        public List<InvoiceItemModel>? invoiceItems { get; set; }
        public Boolean? isActive { get; set; }
    }
}
