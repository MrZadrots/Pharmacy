using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Phramacy.src.interfaces;
using Phramacy.src.Model;


namespace Phramacy.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IAllProducts repository;
        public AdminController(IAllProducts repo)
        {
            repository = repo;

        }
        public IActionResult Index() => View(repository.Product);

        public IActionResult RemoveShelfLive() => View(repository.Product.Where(i => i.shelf_life < DateTime.Today));

        public ViewResult Edit(string name) => View(repository.Product.FirstOrDefault(p => p.name == name));

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.name} был изменен";
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }


        public ViewResult Create() => View("Edit", new Product());

        [HttpPost]
        public IActionResult Delete(string name)
        {
            Product deletedProduct = repository.DeleteProduct(name);
            if(deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct} был удален";
            }
            return RedirectToAction("Index");
        }
    }
}
