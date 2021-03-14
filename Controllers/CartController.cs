using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        private Product GetProduct(int productId)
        {
            return Repository.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart");

            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetJson("Cart", cart);
            }

            return cart;
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = GetProduct(productId);

            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = GetProduct(productId);

            if (product != null)
            {
                GetCart().RemoveLine(product);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
