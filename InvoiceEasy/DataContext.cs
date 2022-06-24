using InvoiceEasy.Models;

namespace InvoiceEasy
{
    public class DataContext    : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<InvoiceModel> Invoices { get; set; }
        public DbSet<InvoiceItemModel> InvoiceItems { get; set; }
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }
    }
}
