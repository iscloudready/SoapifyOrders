using System.ServiceModel;
using System.Xml;

namespace SoapifyOrders.XmlRaw
{
    [ServiceContract]
    public interface IRawXmlService
    {
        [OperationContract(Action = "*", ReplyAction = "*")]
        XmlElement Process(XmlElement input);
    }
}