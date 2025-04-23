# 📘 Clean Architecture in .NET API
## **Understanding the 4-Layer Architecture: Domain • Application • Infrastructure • API**

---

### 🔰 **Overview**

> Clean Architecture is a software design pattern that emphasizes separation of concerns, scalability, testability, and maintainability.  
> In a .NET API project, the architecture is typically divided into **four layers**.

---

## 🧱 1. Domain Layer
> "The heart of the system"

- Contains core **business models**, **entities**, and **value objects**
- Defines **business rules** through **aggregates**, **domain events**, and **interfaces**
- No dependencies on other layers

📂 `ProjectName.Domain`

---

## 🎯 2. Application Layer
> "The use-case layer"

- Coordinates **application logic** and **business workflows**
- Implements **CQRS**: Commands, Queries, and their respective handlers
- Contains **DTOs**, **Validators**, **MediatR Handlers**
- Depends only on the Domain layer

📂 `ProjectName.Application`

---

## 🏗 3. Infrastructure Layer
> "The implementation detail"

- Provides concrete implementations for interfaces defined in other layers
- Integrates with external systems: **Databases**, **File Storage**, **Email**, **Redis**, etc.
- Contains EF Core DbContext, Migrations, Service Implementations

📂 `ProjectName.Infrastructure`

---

## 🌐 4. API Layer
> "The delivery mechanism"

- Entry point of the application (usually ASP.NET Core Web API)
- Defines **Controllers**, **Routes**, **Middlewares**, **Filters**
- Responsible for **Dependency Injection**, **Authentication**, and **API Response shaping**

📂 `ProjectName.API`

---

## 🧭 Dependency Rule (Key Principle)
![image](https://github.com/user-attachments/assets/72518bf6-f3c0-4ccb-b6d7-a607774817e1)

> ✅ **Outer layers depend on inner layers.**  
> ❌ Inner layers must never depend on outer layers.

---

### 📌 Summary

| Layer         | Responsibility                          | Depends On             |
|---------------|------------------------------------------|------------------------|
| **Domain**     | Business rules, entities, value objects  | ❌ None                |
| **Application**| Use cases, CQRS, interfaces              | ✅ Domain              |
| **Infrastructure**| Integrations, repositories, external services | ✅ Domain, Application |
| **API**        | Web delivery, routing, controllers       | ✅ Application         |

---

### 🛠 Tools & Libraries Often Used

- **MediatR** – for CQRS and application events
- **FluentValidation** – for input validation
- **Entity Framework Core** – for data persistence
- **AutoMapper** – for DTO mapping

---

### ✨ Benefits of Clean Architecture

- Clear **separation of concerns**
- High **testability** (especially Application & Domain)
- Easy to **maintain** and **extend**
- Ready for **microservices** evolution

---

> 🎓 *"Code should be clean, scalable, and testable.  
> Let the architecture guide the business, not the framework."*

---



