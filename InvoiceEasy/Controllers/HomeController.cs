using InvoiceEasy.Models;
using InvoiceEasy.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InvoiceEasy.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly DataContext context;

        public HomeController(DataContext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            var invoices = this.context.Invoices.Include(m => m.invoiceItems).Select(m => new InvoiceViewModel
            {
                uniqueNumber = m.uniqueNumber.ToString(),
                buyer = m.buyer.ToString(),
                seller = m.seller.ToString()
            });
            return View(invoices);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}