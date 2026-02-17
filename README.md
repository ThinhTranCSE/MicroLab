# MicroLab 🚀

MicroLab is a hands-on learning project focused on building and understanding modern **Microservices Architecture** using **ASP.NET Core** and **.NET 8**.

This repository is designed as a practical lab environment where we explore architectural patterns, clean code principles, and production-ready service design.

---

## 🎯 Purpose

The goal of MicroLab is to:

- Learn how to design and build microservices from scratch
- Understand system boundaries and service decomposition
- Apply Clean Architecture within business services
- Implement API Gateway patterns
- Explore authentication and authorization strategies
- Practice scalable, modular backend development

This project is not just about writing APIs — it is about building systems with proper architectural thinking.

---

## 🏗 Architecture Overview

MicroLab follows a microservices-based architecture with the following components:

```
Client
   ↓
API Gateway
   ↓
AuthService
   ↓
Business Services
   ├── User Service
   ├── Order Service
   └── Payment Service
```


### 🔹 API Gateway
- Central entry point
- Routing
- Authentication
- Rate limiting
- Cross-cutting concerns

### 🔹 Business Services
Each service is independently developed and follows Clean Architecture principles:

```
ServiceName
   ├── Domain
   ├── Application
   ├── Infrastructure
   └── Presentation
```



Each service:
- Has its own responsibility
- Is independently deployable
- Can scale independently
- Owns its own data

---

## 🧠 Architectural Principles

### 1️⃣ Microservices
- Services are loosely coupled
- Communication over HTTP (REST) or events
- Each service has its own lifecycle

### 2️⃣ Clean Architecture (for business services)
- Business logic is independent of frameworks
- Dependencies flow inward
- Infrastructure is replaceable

### 3️⃣ Separation of Concerns
- Gateway handles edge responsibilities
- Services handle business logic
- No business logic inside the gateway

---

## 🛠 Tech Stack

- .NET 8
- ASP.NET Core Web API
- YARP (API Gateway)
- Clean Architecture
- Docker (planned)
- JWT Authentication (planned)
- Event-driven communication (future phase)

---

## 📚 Learning Objectives

Through MicroLab, we aim to understand:

- How to structure real-world backend systems
- When to use microservices vs monolith
- How to avoid over-engineering
- How authentication works in distributed systems
- How to think like a system architect

---

## 🚀 Current Status

MicroLab is an evolving lab environment.

Planned roadmap:

- [x] Setup solution structure
- [x] Create API Gateway
- [ ] Implement User Service
- [ ] Configure YARP routing
- [ ] Add JWT authentication
- [ ] Introduce Docker Compose
- [ ] Add event-driven communication
- [ ] Observability and logging

---

## ⚠️ Important Notes

MicroLab is a learning project.  
Architecture decisions are made to understand trade-offs, not to prematurely optimize.

We believe:

> Architecture is not about complexity —  
> it is about clarity and responsibility.

---

## 📖 Why MicroLab?

Because building microservices is not about copying patterns.  
It is about understanding *why* systems are designed the way they are.

MicroLab exists to build that understanding.

---

## 👨‍💻 Contributors

Built as a learning initiative to deepen knowledge in distributed systems and modern backend architecture.

<p>
  <a href="https://github.com/ChinhLuCSE">
    <img src="https://github.com/ChinhLuCSE.png" width="80px;" />
  </a>
  <a href="https://github.com/ThinhTranCSE">
    <img src="https://github.com/ThinhTranCSE.png" width="80px;" />
  </a>
</p>

---

