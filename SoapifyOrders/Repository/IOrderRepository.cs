using CustomerOrderService.Models;

namespace CustomerOrderService.Repository
{
    public interface IOrderRepository
    {
        void Save(Order order);
        Order Get(int orderId);
    }
}