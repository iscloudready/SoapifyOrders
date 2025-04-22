using System.ServiceModel;
using CustomerOrderService.Models;

namespace CustomerOrderService.Contracts
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        string CreateOrder(Order order);

        [OperationContract]
        Order GetOrder(int orderId);
    }
}