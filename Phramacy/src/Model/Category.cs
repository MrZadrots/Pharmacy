using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Model
{
    public class Category
    {
        public int id { set; get; }
        public string CategoryName { set; get; }
        public string Desc { set; get; }
        public List<Product> products { set; get; }
    }
}
