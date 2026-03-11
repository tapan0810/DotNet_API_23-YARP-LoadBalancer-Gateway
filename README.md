# .NET API Gateway with Load Balancing and Rate Limiting

## Overview

This project demonstrates a **production-style API Gateway architecture** built using **ASP.NET Core** and **YARP (Yet Another Reverse Proxy)**.

The solution simulates a **microservices environment** where multiple backend API instances handle requests through a centralized gateway that manages:

* Load Balancing
* Rate Limiting
* API Routing
* Traffic distribution

This architecture improves **scalability, reliability, and fault tolerance** for modern backend systems.

---

# Architecture

Client requests pass through a centralized **API Gateway**, which distributes traffic across multiple backend services.

```
Client
   |
   v
API Gateway (YARP Reverse Proxy)
   |
   |------ DotNet_API_23
   |------ Dotnet_API_23_2
   |------ DotNet_API_23_3
```

The gateway uses **Round Robin load balancing** to distribute requests evenly between backend services.

---

# Project Structure

```
DotNet_API_23 (Solution)
│
├── DotNet_API_23                # Main API service
│   ├── Controller
│   │   └── HotelController.cs
│   ├── Data
│   │   └── HotelDbContext.cs
│   ├── Entities
│   │   ├── Dtos
│   │   │   ├── CreateHotelDto.cs
│   │   │   ├── GetAllHotelsDto.cs
│   │   │   ├── GetHotelByIdDto.cs
│   │   │   └── UpdateHotelDto.cs
│   │   └── Models
│   │       └── Hotel.cs
│   ├── Mapping
│   │   └── HotelMappingProfile.cs
│   ├── Services
│   │   ├── IHotelService.cs
│   │   └── HotelService.cs
│   ├── Migrations
│   ├── Program.cs
│   └── appsettings.json
│
├── Dotnet_API_23_2              # Backend API instance 2
│   ├── Controllers
│   │   └── API2Controller.cs
│   ├── Program.cs
│   └── appsettings.json
│
├── DotNet_API_23_3              # Backend API instance 3
│   ├── Controllers
│   │   └── API3Controller.cs
│   ├── Program.cs
│   └── appsettings.json
│
└── README.md
```

---

# Features

* API Gateway using YARP
* Load Balancing using Round Robin algorithm
* Rate Limiting using ASP.NET Core Rate Limiter
* Multiple backend API instances
* Clean architecture with Services and DTO layers
* Entity Framework Core integration
* Scalable microservices-ready design

---

# Technologies Used

* ASP.NET Core
* YARP Reverse Proxy
* .NET 8
* Entity Framework Core
* C#
* REST APIs

---

# How Load Balancing Works

The API Gateway distributes incoming requests across multiple backend services.

Example request flow:

```
Request 1 → DotNet_API_23
Request 2 → Dotnet_API_23_2
Request 3 → DotNet_API_23_3
Request 4 → DotNet_API_23
```

This ensures **balanced traffic distribution and improved performance**.

---

# Rate Limiting

Rate limiting is implemented using **ASP.NET Core Rate Limiter Middleware**.

Example configuration:

* Maximum Requests: **10**
* Time Window: **10 seconds**

This prevents:

* API abuse
* Server overload
* Excessive client requests

---

# Running the Project

## 1. Clone the Repository

```
git clone https://github.com/yourusername/DotNet_API_23.git
```

---

## 2. Run Backend API Instances

Run each backend API on different ports.

Example:

```
dotnet run --urls=http://localhost:5001
```

```
dotnet run --urls=http://localhost:5002
```

```
dotnet run --urls=http://localhost:5003
```

---

## 3. Run the API Gateway

Start the gateway service.

```
dotnet run --urls=http://localhost:7000
```

---

## 4. Test the API

Send requests through the gateway.

```
http://localhost:7000/api/hotel
```

The gateway automatically distributes requests across backend APIs.

---

# Example Response

```
Response from server running on port 5001
Response from server running on port 5002
Response from server running on port 5003
```

---

# Future Improvements

* Health Checks for backend services
* Monitoring with Prometheus and Grafana
* JWT Authentication and Authorization
* Docker containerization
* Kubernetes deployment
* Distributed caching with Redis

---

# Use Cases

This architecture is commonly used in:

* Microservices-based systems
* Scalable backend platforms
* Cloud-native applications
* API gateway implementations

---

# Author

Tapan Ray
Software Engineer | .NET Developer
