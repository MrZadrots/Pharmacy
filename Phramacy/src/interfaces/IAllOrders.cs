using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.interfaces
{
    public interface IAllOrders
    {
        IEnumerable<Order> Order { get; }
        IEnumerable<OrderDetail> OrderDetail { get; }
        void createOrder(Order order);
    }
}
