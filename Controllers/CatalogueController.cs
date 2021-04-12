using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;

        public IActionResult Index(string category, [FromRoute]int page = 1)
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
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    Repository.Products.Count :
                    Repository.Products.Where(
                        e => e.Category == category
                    ).Count()
                },
                CurrentCategory = category
            };

            return View(model);
        }
    }
}
