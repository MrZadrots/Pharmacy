using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Phramacy.src.Model;
using Phramacy.src;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Model
{
    public class ShopCart
    {
        private readonly AppDbContent appDbContent;
        public ShopCart(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public string ShopCartId { get; set; } 
        public List<ShopCartItem> ListShopItems { set; get; }
        public static ShopCart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContent>();
            string ShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", ShopCartId);

            return new ShopCart(context) { ShopCartId = ShopCartId };
        }
        public void AddToCart (Product product)
        {
            appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                product = product,
                name = product.name,
                pric = product.price
            }); 
            appDbContent.SaveChanges();
        }
        public void RemoveToCart(string item)
        {
            ShopCartItem delItem = appDbContent.ShopCartItem.Where(x => x.ShopCartId == item).FirstOrDefault();
            appDbContent.Remove(delItem);
            appDbContent.SaveChanges();
        }
        public List<ShopCartItem> getShopItems()
        {
            return appDbContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(c=>c.product).ToList();
        }
    }
}
