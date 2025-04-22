# 🧼 SoapifyOrders (SOAP in C#)

A SOAP-based WCF service implemented in C# using SOLID principles and clean architecture. This solution includes:
- A reusable service library
- A console-based WCF host
- A C# console client
- PowerShell commands to bootstrap the solution

---

## 📁 Project Structure

```
SoapifyOrders/
├── Contracts/         # WCF service contract
├── Models/            # Data contracts
├── Repository/        # Data handling logic
├── Services/          # Business logic and service implementation
├── SoapifyOrders.Host/   # Console-based host
├── SoapifyOrders.Client/ # Console-based client
```

---

## ⚙️ How to Build & Run

### ✅ Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (>= .NET 6)
- Visual Studio or `dotnet` CLI

---

### 🧪 Clone and Setup

```bash
git clone https://github.com/your-username/SoapifyOrders.git
cd SoapifyOrders
```

---

### ⚡ PowerShell Bootstrap (optional)

You can also use the script below to initialize the project manually.

```powershell
dotnet new sln -n SoapifyOrders
dotnet new wcf -n SoapifyOrders
dotnet new console -n SoapifyOrders.Host
dotnet new console -n SoapifyOrders.Client

dotnet sln add SoapifyOrders/SoapifyOrders.csproj
dotnet sln add SoapifyOrders.Host/SoapifyOrders.Host.csproj
dotnet sln add SoapifyOrders.Client/SoapifyOrders.Client.csproj

dotnet add SoapifyOrders.Host/SoapifyOrders.Host.csproj reference SoapifyOrders/SoapifyOrders.csproj
dotnet add SoapifyOrders.Client/SoapifyOrders.Client.csproj reference SoapifyOrders/SoapifyOrders.csproj
```

---

### ▶️ Running the Service

1. **Run the Host**  
   Launch the service in terminal:
   ```bash
   dotnet run --project SoapifyOrders.Host
   ```

2. **Run the Client**  
   In a new terminal:
   ```bash
   dotnet run --project SoapifyOrders.Client
   ```

---

### 🧪 Sample Output

```
Service is running at http://localhost:8000/OrderService
Order Created!
Fetched Order: Laptop, Qty: 2
```

---

## 👨‍💻 Features

- SOLID principles (SRP, DIP, ISP, OCP)
- Clean separation of responsibilities
- Easily testable architecture
- Extendable repository layer
- Example SOAP bindings via WCF

---

## 🧱 Extending the Service

You can enhance this project by:
- Adding real database connectivity (EF Core)
- Hosting via IIS or Kestrel
- Securing endpoints with credentials
- Creating Swagger-compatible REST endpoints (bonus track)

---

## 💡 License

This project is open-sourced under the MIT License.
See the [LICENSE](LICENSE) file for more information.

---

## 🙌 Author

Made with ❤️ by [Your Name](https://github.com/your-username)
