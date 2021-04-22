using MbmStore.Data;
using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private MbmStoreContext dataContext;
        private List<Invoice> invoices = new List<Invoice>();
        private List<SelectListItem> customers = new List<SelectListItem>();
        public InvoiceController(MbmStoreContext dbContext)
        {
            dataContext = dbContext;
            invoices = dataContext
                        .Invoices.Include(invoice => invoice.Customer)
                        .Include(invoice => invoice.OrderItems)
                        .ThenInclude(orderItem => orderItem.Product).ToList();
        }

        public IActionResult Index()
        {
            SetupCustomerSelect();

            ViewBag.Invoices = invoices;
            ViewBag.Customers = customers;

            return View();
        }

        [HttpPost]
        public IActionResult Index(int? customer)
        {
            SetupCustomerSelect();

            //Keep the selected value the same
            foreach (SelectListItem customerItem in customers)
            {
                if (Convert.ToInt32(customerItem.Value) == customer)
                {
                    customerItem.Selected = true;
                }
            }

            if (customer != null && customer != 0)
            {
                invoices = dataContext.Invoices.Where(r => r.Customer.CustomerId == customer).ToList();
            }

            ViewBag.Invoices = invoices;
            ViewBag.Customers = customers;

            return View();
        }

        private void SetupCustomerSelect()
        {
            foreach (Invoice invoice in invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = $"{invoice.Customer.FirstName} {invoice.Customer.LastName}",
                    Value = invoice.Customer.CustomerId.ToString()
                });
            }

            customers.Add(new SelectListItem { Text = "All", Value = "0" });

            customers = customers.GroupBy(x => x.Value)
                                 .Select(y => y.First())
                                 .OrderBy(z => z.Text)
                                 .ToList<SelectListItem>();
        }
    }
}
