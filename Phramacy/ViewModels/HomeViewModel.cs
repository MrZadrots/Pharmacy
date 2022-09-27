using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> favproducts { get; set; }
    }
}
