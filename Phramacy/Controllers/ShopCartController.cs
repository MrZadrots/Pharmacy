using Microsoft.AspNetCore.Mvc;
using Phramacy.src.interfaces;
using Phramacy.src.Model;
using Phramacy.ViewModels;
using Phramacy.src.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllProducts productRep;
        private readonly ShopCart _shopCart = null;

        public ShopCartController(IAllProducts _productRep, ShopCart shopCart)
        {
            productRep = _productRep;
            _shopCart = shopCart;
        }
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItems = items;
            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = productRep.Product.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);

            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveToCart(string item)
        {
            _shopCart.RemoveToCart(item);
            return RedirectToAction("Index");
        }
    }
}
