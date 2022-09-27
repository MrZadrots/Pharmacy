using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Phramacy.src.interfaces;
using Phramacy.src.Model;
using Phramacy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy
{
    public class HomeController : Controller 
    {
        private readonly IAllProducts productRep;
        public HomeController(IAllProducts _productRep)
        {
            productRep = _productRep;
        }


        public ViewResult Index()
        {
            var shopProducts = new HomeViewModel
            {
                favproducts = productRep.getFavProduct
            };
            return View(shopProducts);
        }

        public IActionResult Search (string searchString)
        {
            var products = from m in productRep.Product select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.name == searchString);
            }
            return View(products);
        }
    }
}
