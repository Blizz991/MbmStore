using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;

        public IActionResult Index(int page = 1)
        {
            //ViewBag.Products = Repository.Products;

            // Not the smartest way of doing this, but sticking to the previous code we made in the previous assignments...
            //ViewBag.Books = Repository.Products.OfType<Book>().ToList();
            //ViewBag.MusicCDs = Repository.Products.OfType<MusicCD>().ToList();
            //ViewBag.Movies = Repository.Products.OfType<Movie>().ToList();

            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = Repository.Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = Repository.Products.Count
                }
            };

            return View(model);
        }
    }
}
