using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Order.Add(order);

            var shoppingcartitem = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingcartItem in shoppingcartitem)
            {
                var orderdetail = new OrderDetail
                {
                    Amount = shoppingcartItem.Amount,
                    PieID = shoppingcartItem.pie.pieID,
                    OrderID = order.OrderId,
                    Price = shoppingcartItem.pie.Price
                };

                _appDbContext.OrderDetails.Add(orderdetail);
            }
            _appDbContext.SaveChanges();
        }
    }
}
