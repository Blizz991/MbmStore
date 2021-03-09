using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private List<Invoice> invoices = Repository.Invoices;

        public IActionResult Index()
        {
            List<SelectListItem> customers = new List<SelectListItem>();

            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = $"{invoice.Customer.FirstName} {invoice.Customer.LastName}",
                    Value = invoice.Customer.CustomerId.ToString()
                }) ;
            }

            customers.Add(new SelectListItem { Text = "All", Value = "0" });

            customers = customers.GroupBy(x => x.Value)
                                 .Select(y => y.First())
                                 .OrderBy(z => z.Text)
                                 .ToList<SelectListItem>();

            ViewBag.Invoices = invoices;
            ViewBag.Customers = customers;

            return View();
        }

        [HttpPost]
        public IActionResult Index(int? customer)
        {
            invoices = Repository.Invoices;

            List<SelectListItem> customers = new List<SelectListItem>();

            foreach (Invoice invoice in Repository.Invoices)
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

            // Keep the selected value the same
            foreach (SelectListItem customerItem in customers)
            {
                if (Convert.ToInt32(customerItem.Value) == customer)
                {
                    customerItem.Selected = true;
                }
            }

            if (customer != null && customer != 0)
            {
                invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == customer).ToList();
            }

            ViewBag.Invoices = invoices;
            ViewBag.Customers = customers;

            return View();
        }
    }
}
