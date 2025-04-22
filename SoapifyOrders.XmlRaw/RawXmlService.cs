using System.Xml;

namespace SoapifyOrders.XmlRaw
{
    public class RawXmlService : IRawXmlService
    {
        public XmlElement Process(XmlElement input)
        {
            var responseDoc = new XmlDocument();
            var responseXml = "<CustomResponse><Status>Success</Status><OrderId>501</OrderId></CustomResponse>";
            responseDoc.LoadXml(responseXml);
            return responseDoc.DocumentElement;
        }
    }
}