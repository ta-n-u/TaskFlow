# TaskFlow — Task Manager Web App

A full-stack task management web application built with ASP.NET Core MVC, Entity Framework Core, and SQL Server.

## Features

- Create, edit, and delete tasks
- Set priority levels (Low, Medium, High)
- Set due dates
- One-click status toggle (Pending / Done)
- Responsive UI with Bootstrap

## Tech Stack

- **Backend:** C#, ASP.NET Core MVC (.NET 8)
- **ORM:** Entity Framework Core 8
- **Database:** SQL Server (LocalDB)
- **Frontend:** Razor Views, Bootstrap 5
- **Tools:** Visual Studio 2022, Git

## Concepts Applied

- MVC architecture (Model, View, Controller)
- Object-Oriented Programming (classes, inheritance, encapsulation)
- Dependency Injection
- Async/await programming
- Database migrations with EF Core
- Data annotations and model validation
- CSRF protection with AntiForgeryToken
- CRUD operations

## Getting Started

### Prerequisites
- Visual Studio 2022
- .NET 8 SDK
- SQL Server (LocalDB)

### Setup

1. Clone the repository
2. Open `TaskFlow.sln` in Visual Studio
3. Run database migrations in Package Manager Console
4. Run the app with `Ctrl + F5`
5. Navigate to `/Task` to start managing tasks

## Project Structure
TaskFlow/
├── Controllers/
│   └── TaskController.cs    # Handles all task-related requests
├── Models/
│   ├── TaskItem.cs          # Task data model
│   └── AppDbContext.cs      # Entity Framework database context
├── Views/
│   └── Task/
│       ├── Index.cshtml     # Task list page
│       ├── Create.cshtml    # Create task form
│       └── Edit.cshtml      # Edit task form
└── appsettings.json         # Configuration and connection string


## What I Learned

- How ASP.NET Core MVC handles the request-response cycle
- How Entity Framework Core maps C# classes to database tables
- How dependency injection works in .NET
- How to use migrations to manage database schema changes
- How Razor views combine C# and HTML
