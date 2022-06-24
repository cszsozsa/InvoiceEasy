using InvoiceEasy.Models;

namespace InvoiceEasy
{
    public static class TestData
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<DataContext>();
            context.Database.EnsureCreated();
            AddData(context);
        }

        private static void AddData(DataContext context)
        {
            var data = context.Invoices.FirstOrDefault();
            if (data != null) return;

            context.Invoices.Add(new InvoiceModel
            {
                uniqueNumber = 157289,
                seller = new PersonModel { firstName = "Patrik", lastName = "Pelda", address = "test"},
                buyer = new PersonModel { firstName = "Peter", lastName = "Pelda", address = "test2" },
                invoiceItems = new List<InvoiceItemModel> {
                    new InvoiceItemModel {
                        name = "Krumpli",
                        cost = 400,
                        quantity = 10,
                        description = "Pityoka",
                        isActive = true
                    } }
            });

            context.SaveChanges();
        }
    }
}
