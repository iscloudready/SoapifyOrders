using System;
using System.ServiceModel;
using CustomerOrderService.Contracts;
using CustomerOrderService.Services;

namespace CustomerOrderService.Host
{
    class Program
    {
        static void Main()
        {
            Uri baseAddress = new Uri("http://localhost:8000/OrderService");
            using ServiceHost host = new(typeof(OrderService), new(baseAddress));

            host.Open();
            Console.WriteLine("Service is running at {0}", baseAddress);
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}