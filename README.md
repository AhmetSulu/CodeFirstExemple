# CodeFirstExemple

This project demonstrates a **Code First** approach using **ASP.NET Core 6** and **Entity Framework Core**. It manages two entities: Movies and Games.

## Features
- Code First database creation.
- CRUD operations for Movies and Games.
- SQL Server as the database.

## Entities
- **Movie**: Id, Title, Genre, ReleaseYear.
- **Game**: Id, Name, Platform, Rating.

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server or LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-2019-setup?view=sql-server-ver15)

### Installation
1. Clone the repo:  
   `https://github.com/AhmetSulu/CodeFirstExemple.git`

2. Update `appsettings.json` with your SQL Server connection.

3. Run migrations:  
   `dotnet ef migrations add InitialCreate`  
   `dotnet ef database update`

4. Start the app:  
   `dotnet run`
