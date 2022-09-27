using Microsoft.EntityFrameworkCore;
using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src
{
    public class AppDbContent:DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options) { 
        }
        public DbSet<Product> Product_Db { set; get; }
        public DbSet<Category> Category_Db { set; get; }
        public DbSet<ShopCartItem> ShopCartItem { set; get; }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetail> OrderDetail { set; get; }

    }
}
