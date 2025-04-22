using CustomerOrderService.Contracts;
using CustomerOrderService.Models;
using CustomerOrderService.Repository;

namespace CustomerOrderService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService() : this(new OrderRepository()) {}

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public string CreateOrder(Order order)
        {
            _repository.Save(order);
            return "Order Created!";
        }

        public Order GetOrder(int orderId)
        {
            return _repository.Get(orderId);
        }
    }
}