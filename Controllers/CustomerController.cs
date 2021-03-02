using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer("Lasse", "Olsen", new DateTime(1991,02,09), "Naturvej 21", 8361, "Hasselager", new int[] {12345678, 23456789 }),
                new Customer("Mikkel", "Viadith", new DateTime(1957,05,17), "Danskgade 23", 8000, "Aarhus", new int[] {23456781, 34567892 }),
                new Customer("Oscar", "Lacour", new DateTime(1965,04,22), "Violvej 121", 8000, "Aarhus", new int[] {34567812, 45678923 }),
                new Customer("Bente", "Hansen", new DateTime(1911,12,23), "Slotsgade", 8000, "Aarhus", new int[] {45678123, 56789234 }),
                new Customer("Viola", "Fisker", new DateTime(1945,10,11), "Bavnestræde 221", 8000, "Aarhus", new int[] {56781234, 67892345 }),
                new Customer("Trine", "Jakobsen", new DateTime(2010,03,28), "Toften 69", 8361, "Hasselager", new int[] {67812345, 78923456 })
            };

            #region original customers
            //var customer1 = new Customer("Lasse", "Olsen", "Naturvej 21", 8361, "Hasselager", 12345678);
            //var customer2 = new Customer("Mikkel", "Viadith", "Danskgade 23", 8000, "Aarhus", 23456781);
            //var customer3 = new Customer("Oscar", "Lacour", "Violvej 121", 8000, "Aarhus", 34567812);
            //var customer4 = new Customer("Bente", "Hansen", "Slotsgade", 8000, "Aarhus", 45678123);
            //var customer5 = new Customer("Viola", "Fisker", "Bavnestræde 221", 8000, "Aarhus", 56781234);
            //var customer6 = new Customer("Trine", "Jakobsen", "Toften 69", 8361, "Hasselager", 67812345);

            //ViewBag.Customer1 = customer1;
            //ViewBag.Customer2 = customer2;
            //ViewBag.Customer3 = customer3;
            //ViewBag.Customer4 = customer4;
            //ViewBag.Customer5 = customer5;
            //ViewBag.Customer6 = customer6;
            #endregion

            ViewBag.Customers = customers;

            return View();
        }
    }
}
