using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Model
{
    public class Product
    {
        private readonly AppDbContent appDbContent;
        public int id { set; get; }
        public string name { set; get; }
        public string shortDec { set; get; }
        public string longDec { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool IsFavourite { set; get; }
        public int available { set; get; }
        public int CategoryId { set; get; }
        public DateTime shelf_life { set; get; }
        public Category Category { set; get; }


    }
}
