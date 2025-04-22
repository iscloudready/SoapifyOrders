# 🧼 SoapifyOrders Full Solution (SOAP + Raw XML)

This full solution contains:
- ✅ Standard SOAP WCF service using typed contracts
- ✅ Raw XML-based SOAP service using XmlElement
- ✅ Console-based hosts
- ✅ Client sample
- ✅ XML samples for testing

---

## 📁 Projects Included

```
SoapifyOrders/                  # Original service (typed)
SoapifyOrders.Host/            # Host for typed service
SoapifyOrders.Client/          # Client consuming typed service
SoapifyOrders.XmlRaw/          # Raw XML SOAP endpoint
SoapifyOrders.XmlRaw.Host/     # Host for raw XML service
```

---

## ▶️ Run the Services

### 1. Typed WCF Service
```bash
dotnet run --project SoapifyOrders.Host
```

### 2. Raw XML Service
```bash
dotnet run --project SoapifyOrders.XmlRaw.Host
```

---

## 🔁 Sample Raw XML

### Request (SoapifyOrders.XmlRaw/Samples/SampleRequest.xml)
```xml
<CustomRequest>
  <CustomerId>101</CustomerId>
  <Product>Book</Product>
</CustomRequest>
```

### Response (SoapifyOrders.XmlRaw/Samples/SampleResponse.xml)
```xml
<CustomResponse>
  <Status>Success</Status>
  <OrderId>501</OrderId>
</CustomResponse>
```

---

## ✨ Features

- SOLID + OOP in all services
- Accepts both typed and raw XML payloads
- Full Visual Studio + dotnet CLI support
- Extendable & testable