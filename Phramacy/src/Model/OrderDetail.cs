using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Model
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int ProductID { get; set; }
        public uint price{ get; set; }
        public virtual Product product { get; set; }
        public virtual Order order { get; set; }
    }
}
