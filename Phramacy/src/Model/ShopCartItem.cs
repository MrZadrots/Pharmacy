using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Model
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Product product { get; set; }
        public string name { set; get; }
        public int pric { get; set; }
        public string ShopCartId { get; set; }
    }
}
