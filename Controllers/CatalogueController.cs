using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Products = Repository.Products;

            // Not the smartest way of doing this, but sticking to the previous code we made in the previous assignments...
            //ViewBag.Books = Repository.Products.OfType<Book>().ToList();
            //ViewBag.MusicCDs = Repository.Products.OfType<MusicCD>().ToList();
            //ViewBag.Movies = Repository.Products.OfType<Movie>().ToList();

            return View(Repository.Products);
        }
    }
}
