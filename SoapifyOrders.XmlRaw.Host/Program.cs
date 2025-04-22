using System;
using System.ServiceModel;
using SoapifyOrders.XmlRaw;

namespace SoapifyOrders.XmlRaw.Host
{
    class Program
    {
        static void Main()
        {
            Uri baseAddress = new Uri("http://localhost:8090/RawXmlService");
            using ServiceHost host = new(typeof(RawXmlService), new(baseAddress));

            host.Open();
            Console.WriteLine("Raw XML SOAP Service is running at {0}", baseAddress);
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}