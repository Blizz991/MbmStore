using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            // create a new Movie object with instance name jungleBook
            var jungleBook = new Movie("Jungle Book", 160.50m, "Someone 1", "junglebook.jpg");
            var gladiator = new Movie("Gladiator", 99.99m, "Someone 2", "gladiator.jpg");
            var forestGump = new Movie("Forrest Gump", 129.99m, "Someone 3", "forrest-gump.jpg");

            // assign a ViewBag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.Gladiator = gladiator;
            ViewBag.ForestGump = forestGump;

            // return the default view
            return View();
        }
    }
}