using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.CurrentCategory = RouteData?.Values["category"];
            return View(Repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
            );
        }
    }
}
