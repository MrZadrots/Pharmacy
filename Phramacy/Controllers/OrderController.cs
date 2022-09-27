using Microsoft.AspNetCore.Mvc;
using Phramacy.src;
using Phramacy.src.interfaces;
using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(IAllOrders _allOrder, ShopCart _shopCart)
        {
            this.allOrders = _allOrder;
            this.shopCart = _shopCart;
        }


        public IActionResult Checkout()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.ListShopItems = shopCart.getShopItems();
            if (shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("","У вас должны быть товары в корзине");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан!";
            return View();
        }
    }
}
    