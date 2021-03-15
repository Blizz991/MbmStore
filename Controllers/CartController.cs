using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;

        public CartController(Cart cartservice)
        {
            cart = cartservice;
        }

        private Product GetProduct(int productId)
        {
            return Repository.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = GetProduct(productId);

            if (product != null)
            {
                cart.AddItem(product, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = GetProduct(productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public ViewResult Index(string returnUrl)
        {
            return View(
                new CartIndexViewModel
                {
                    Cart = cart,
                    ReturnUrl = returnUrl
                }
            );
        }

        //private Cart cart;
        //public CartController(Cart cartService) { cart = cartService; }
        //public ViewResult Index(string returnUrl) { return View(new CartIndexViewModel{ Cart = cart, ReturnUrl = returnUrl}); }
        //public RedirectToActionResult AddToCart(int productID, string returnUrl) { Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productID); if (product != null) { cart.AddItem(product, 1); } return RedirectToAction("Index", new { returnUrl }); }
        //public RedirectToActionResult RemoveFromCart(int productID, string returnUrl){ Product product = Repository.Products.FirstOrDefault(p => p.ProductId == productID); if (product != null) { cart.RemoveLine(product); } return RedirectToAction("Index", new { returnUrl }); }
    }
}
