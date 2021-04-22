using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MbmStore.Models.ViewModels;
using MbmStore.Data;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;
        private MbmStoreContext dataContext;

        public CartController(Cart cartservice, MbmStoreContext dbContext)
        {
            cart = cartservice;
            dataContext = dbContext;
        }

        private Product GetProduct(int productId)
        {
            return dataContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public RedirectToActionResult AddToCart(int productId, int quantity, string returnUrl)
        {
            Product product = GetProduct(productId);

            if (product != null)
            {
                cart.AddItem(product, quantity);
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

        public RedirectToActionResult AdjustQuantityOfProductInCart(int productId, string returnUrl)
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
    }
}
