using System.Collections.Generic;
using CustomerOrderService.Models;

namespace CustomerOrderService.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private static readonly Dictionary<int, Order> _orders = new();

        public void Save(Order order)
        {
            _orders[order.OrderId] = order;
        }

        public Order Get(int orderId)
        {
            _orders.TryGetValue(orderId, out var order);
            return order;
        }
    }
}