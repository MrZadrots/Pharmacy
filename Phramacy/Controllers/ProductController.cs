using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Phramacy.src.interfaces;
using Phramacy.src.Model;
using Phramacy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.Controllers
{
    public class ProductController:Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductCategory _allCategoroies;
        public ProductController(IAllProducts allProducts,IProductCategory allCategories)
        {
            _allProducts = allProducts;
            _allCategoroies = allCategories;
        }
        [Route("Product/List")]
        [Route("Product/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> product;
            string ProductCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                product = _allProducts.Product.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Bads", category, StringComparison.OrdinalIgnoreCase))
                {
                    product = _allProducts.Product.Where(i => i.Category.CategoryName.Equals("БАДЫ")).Where(i=>i.available>0).OrderBy(i => i.id); 
                }
                else {
                    product = _allProducts.Product.Where(i => i.Category.CategoryName.Equals("Лекартсвенные средства")).Where(i => i.available > 0).OrderBy(i => i.id);
                }
                ProductCategory = _category;

               
            }
            var productObj = new ProductsListViewModel
            {
                getAllProducts = product,
                productsCategory = "Товары"
            };
            ViewBag.Title = "Страница с товарами";
            return View(productObj);
        }
    }
}
