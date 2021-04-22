using MbmStore.Data;
using MbmStore.Infrastructure;
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
        private MbmStoreContext dataContext;

        public CustomerController(MbmStoreContext dbcontext)
        {
            dataContext = dbcontext;
        }

        public IActionResult Index()
        {
            ViewBag.Customers = dataContext.Customers;

            return View();
        }
    }
}
