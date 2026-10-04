# Design Patterns in C#

A practical collection of **Design Pattern implementations in C#**, created while learning Low-Level Design (LLD), SOLID principles, and object-oriented design.

The goal of this repository is not just to memorize design patterns, but to understand **when, why, and how to use them in real-world applications**.

---

## 📚 Design Patterns Covered

### Creational Patterns

Patterns related to object creation.

- Singleton
- Factory Method
- Abstract Factory
- Builder
- Prototype

### Structural Patterns

Patterns related to object and class composition.

- Adapter
- Decorator
- Facade
- Proxy
- Composite
- Bridge
- Flyweight

### Behavioral Patterns

Patterns related to communication and behavior between objects.

- Strategy
- Observer
- Chain of Responsibility
- Command
- State
- Template Method
- Mediator
- Memento
- Iterator
- Visitor

---

## 🧱 Additional Design Concepts

This repository also contains implementations and examples related to:

- SOLID Principles
- Dependency Injection
- Repository Pattern
- Unit of Work
- Specification Pattern
- CQRS
- Clean Architecture concepts

---

## 🗂️ Project Structure

```text
DesignPatterns/
│
├── Creational/
│   ├── Singleton/
│   ├── Factory/
│   ├── Builder/
│   ├── AbstractFactory/
│   └── Prototype/
│
├── Structural/
│   ├── Adapter/
│   ├── Decorator/
│   ├── Facade/
│   ├── Proxy/
│   ├── Composite/
│   ├── Bridge/
│   └── Flyweight/
│
├── Behavioral/
│   ├── Strategy/
│   ├── Observer/
│   ├── ChainOfResponsibility/
│   ├── Command/
│   ├── State/
│   ├── TemplateMethod/
│   ├── Mediator/
│   ├── Memento/
│   ├── Iterator/
│   └── Visitor/
│
├── SOLID/
│
├── DependencyInjection/
│
├── Repository/
│
├── UnitOfWork/
│
├── Specification/
│
└── README.md
```

---

## 🎯 Learning Approach

For each design pattern, the implementation focuses on:

1. What problem does the pattern solve?
2. When should it be used?
3. What problem exists without the pattern?
4. How does the pattern solve the problem?
5. C# implementation
6. Object and execution flow
7. SOLID principles involved
8. Real-world use cases
9. Advantages and disadvantages
10. Comparison with similar patterns

---

## 🔥 Important Patterns

Some of the patterns that are particularly useful in real-world .NET applications:

### Strategy

Useful when an application needs multiple interchangeable algorithms.

Examples:

- Payment methods
- Pricing strategies
- Queue allocation
- Notification providers

### Factory

Useful when object creation contains varying logic.

Examples:

- Payment providers
- Notification providers
- Vehicle creation
- Database providers

### Decorator

Useful for dynamically adding responsibilities.

Examples:

- Logging
- Caching
- Retry
- Metrics
- Authorization

### Observer

Useful for one-to-many notifications.

Examples:

- Notifications
- Event systems
- Real-time dashboards
- SignalR applications

### State

Useful when an object's behavior changes based on its current state.

Examples:

- Order lifecycle
- Payment lifecycle
- Queue token lifecycle
- Ticket lifecycle

### Mediator

Useful for reducing direct communication between application components.

Commonly used with:

- CQRS
- Command handlers
- Query handlers
- Application services

---

## 💻 Technologies

- C#
- .NET
- Object-Oriented Programming
- SOLID Principles
- Design Patterns
- Clean Architecture concepts
- Dependency Injection

---

## 🚀 Future LLD Problems

After completing the design patterns, this repository will be extended with complete Low-Level Design problems:

- Parking Lot
- ATM
- Elevator System
- Library Management System
- Hotel Management System
- E-Commerce System
- Payment System
- Notification System
- Queue Management System

---

## 🧠 Learning Roadmap

```text
OOP
 ↓
SOLID Principles
 ↓
Design Patterns
 ↓
Pattern Combinations
 ↓
LLD Problems
 ↓
Concurrency
 ↓
API & Database Design
 ↓
System Design
```

---

## 👨‍💻 Author

**Nitesh Chaurasiya**

Software Engineer | Backend Developer | C# | .NET | ASP.NET Core | SQL Server

---

## ⭐ Purpose

This repository is created for:

- Learning
- Practice
- Interview preparation
- LLD preparation
- Understanding real-world software design

If you find it useful, feel free to ⭐ the repository.