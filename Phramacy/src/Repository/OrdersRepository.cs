using Microsoft.EntityFrameworkCore;
using Phramacy.src.interfaces;
using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDbContent appDbContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDbContent _appDbContent, ShopCart _shopCart)
        {
            this.appDbContent = _appDbContent;
            this.shopCart = _shopCart;
        }

        public IEnumerable<Order> Order => appDbContent.Order.Include(i=> i.orderDetails);

        public IEnumerable<OrderDetail> OrderDetail => appDbContent.OrderDetail.Include(i => i.id);

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDbContent.Order.Add(order);


            var items = shopCart.ListShopItems;

            foreach (var el in items)
            {
                Product products = appDbContent.Product_Db.FirstOrDefault(i => i.name == el.name);
                var orderdetail = new OrderDetail()
                {
                    ProductID = products.id,
                    orderID = order.id,
                    price = el.product.price,
                };
                appDbContent.OrderDetail.Add(orderdetail);
                Product product = appDbContent.Product_Db.FirstOrDefault(i => i.id == orderdetail.ProductID);
                product.available--;

            }
            appDbContent.SaveChanges();
        }


    }
}
