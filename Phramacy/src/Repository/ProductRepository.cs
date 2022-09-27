using Microsoft.EntityFrameworkCore;
using Phramacy.src.interfaces;
using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDbContent appDbContent;
        public ProductRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Product> Product => appDbContent.Product_Db.Include(c=>c.Category);

        public IEnumerable<Product> getFavProduct => appDbContent.Product_Db.Where(p => p.IsFavourite).Include(c=>c.Category);

        public Product getProduct(int ProductId) => appDbContent.Product_Db.FirstOrDefault(p => p.id == ProductId);

        //public void SaveProduct(Product product)
        //{
        //    if (product.name != null)
        //    {
        //        appDbContent.Product_Db.Add(product);
        //    }
        //    else
        //    {
        //        Product dbEntry = appDbContent.Product_Db.FirstOrDefault(p => p.name == product.name);
        //        if (dbEntry != null)
        //        {
        //            //dbEntry.name = product.name;
        //            dbEntry.shortDec = product.name;
        //            dbEntry.price = product.price;
        //            dbEntry.available = product.available;
        //            dbEntry.img = product.img;
        //            dbEntry.IsFavourite = product.IsFavourite;
        //            dbEntry.shelf_life = product.shelf_life;
        //            dbEntry.CategoryId = product.CategoryId;
        //        }
        //    }
        //    appDbContent.SaveChanges();
        //}
        public void SaveProduct(Product product)
        {
            Product dbEntry = appDbContent.Product_Db.FirstOrDefault(p => p.name == product.name);
            if (dbEntry != null)
            {
                dbEntry.name = product.name;
                dbEntry.shortDec = product.shortDec;
                dbEntry.price = product.price;
                dbEntry.available = product.available;
                dbEntry.img = product.img;
                dbEntry.IsFavourite = product.IsFavourite;
                dbEntry.shelf_life = product.shelf_life;
                dbEntry.CategoryId = product.CategoryId;
            }
            else
            {
                appDbContent.Product_Db.Add(product);
            }
            appDbContent.SaveChanges();
        }
        public Product DeleteProduct(string name)
        {
            Product dbEntry = appDbContent.Product_Db.FirstOrDefault(p => p.name == name);
            if (dbEntry != null)
            {
                appDbContent.Product_Db.Remove(dbEntry);
                appDbContent.SaveChanges();
            }
            return dbEntry;
        }
    }
}
