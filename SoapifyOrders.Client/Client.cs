using System;
using System.ServiceModel;
using CustomerOrderService.Contracts;
using CustomerOrderService.Models;

namespace CustomerOrderService.Client
{
    class Client
    {
        static void Main()
        {
            ChannelFactory<IOrderService> factory = new ChannelFactory<IOrderService>(
                new BasicHttpBinding(),
                new EndpointAddress("http://localhost:8000/OrderService"));

            IOrderService client = factory.CreateChannel();

            var newOrder = new Order { OrderId = 1, ProductName = "Laptop", Quantity = 2 };
            string result = client.CreateOrder(newOrder);
            Console.WriteLine(result);

            var fetchedOrder = client.GetOrder(1);
            Console.WriteLine($"Fetched Order: {fetchedOrder.ProductName}, Qty: {fetchedOrder.Quantity}");
        }
    }
}