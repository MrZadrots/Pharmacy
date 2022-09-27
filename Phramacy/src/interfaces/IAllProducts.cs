using Microsoft.AspNetCore.SignalR;
using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Product {get;}
        IEnumerable<Product> getFavProduct { get; }
        Product getProduct(int ProductId);
        void SaveProduct(Product product);
        Product DeleteProduct(string name);
    }
}
