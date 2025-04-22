# CustomerOrderService (SOAP in C#)

A SOAP-based WCF service implemented in C# following SOLID principles.

## 🔧 Features
- Create and fetch customer orders
- Follows OOP and SOLID
- Includes a PowerShell script to generate the structure
- Ready-to-run host and client projects

## 📁 Project Structure
```
CustomerOrderService/
├── Contracts/         # WCF service interface
├── Models/            # Data contracts
├── Repository/        # Data handling logic
├── Services/          # Business logic
├── CustomerOrderService.Host/   # Console host
├── CustomerOrderService.Client/ # Console client
```

## ▶️ Running the Project

1. Open solution in Visual Studio
2. Run the `CustomerOrderService.Host`
3. Then run the `CustomerOrderService.Client`

## 💡 Notes
- Ensure the WCF bindings are properly configured in App.config if required.
- The host must be running before the client is executed.

## 👨‍💻 How to Use

- Modify the `OrderService` logic to connect to a real DB.
- Extend `IOrderRepository` to use Entity Framework or other storage.

Enjoy SOAP the clean way 🚿