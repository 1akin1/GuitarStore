# GuitarStore

A full-stack ASP.NET Core MVC e-commerce web application for browsing and purchasing guitars online.

## Features

- **Guitar Catalog** — Browse 20 guitars across Electric, Acoustic, and Classical categories
- **Filtering** — Filter by brand, category, and price range
- **Shopping Cart** — Add, remove, and adjust quantities with session-based cart
- **User Authentication** — Register and login with ASP.NET Core Identity
- **Role-Based Access** — Admin and Customer roles
- **Admin Panel** — Add, edit, delete guitars and manage prices (Admin only)
- **Checkout Page** — Order summary with shipping form
- **Responsive UI** — Built with Bootstrap 5 and Bootstrap Icons

## Tech Stack

- **Framework:** ASP.NET Core MVC (.NET 10)
- **Database:** SQLite via Entity Framework Core
- **Authentication:** ASP.NET Core Identity
- **Frontend:** Bootstrap 5, Bootstrap Icons
- **ORM:** Entity Framework Core 9

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10)

### Installation

1. Clone the repository
```bash
   git clone https://github.com/yourusername/GuitarStore.git
   cd GuitarStore/GuitarStore
```

2. Install the EF Core tools if you don't have them
```bash
   dotnet tool install --global dotnet-ef
```

3. Apply database migrations
```bash
   dotnet ef database update
```

4. Run the application
```bash
   dotnet run
```

5. Open your browser and navigate to `http://localhost:5044`

## Default Admin Account

An admin account is automatically created on first run:

| Field    | Value                     |
|----------|---------------------------|
| Email    | admin@guitarstore.com     |
| Password | Admin123!                 |

## Project Structure

GuitarStore/
├── Controllers/
│   ├── AccountController.cs    # Login, register, logout
│   ├── AdminController.cs      # Admin panel (add/edit/delete guitars)
│   ├── CartController.cs       # Cart management
│   ├── CatalogController.cs    # Guitar catalog with filtering
│   └── HomeController.cs       # Home page
├── Data/
│   └── GuitarContext.cs        # EF Core DbContext with seed data
├── Models/
│   ├── AccountViewModels.cs    # Login and register view models
│   ├── CartItem.cs
│   ├── Category.cs
│   ├── Guitar.cs
│   ├── Order.cs
│   └── OrderedItem.cs
├── Views/
│   ├── Account/                # Login, Register, AccessDenied
│   ├── Admin/                  # Admin panel, Add/Edit guitar
│   ├── Cart/                   # Cart, Checkout
│   ├── Catalog/                # Guitar catalog
│   ├── Home/                   # Home page
│   └── Shared/                 # Layout
└── Extensions/
└── SessionExtensions.cs    # Session helpers for cart

## Screenshots
<img width="1885" height="942" alt="0" src="https://github.com/user-attachments/assets/ddde368d-0367-4d6e-bfed-a40a3eba8c3a" />
<img width="1340" height="391" alt="1" src="https://github.com/user-attachments/assets/4ef1b987-e722-4518-85da-7de9c2ada34d" />
<img width="1366" height="441" alt="4" src="https://github.com/user-attachments/assets/82e573cd-79cf-4d00-9f80-a0db7d2bae2b" />


## License

This project is licensed under the MIT License.
