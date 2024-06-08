# Employee Management Application

## Overview

The Employee Management application is designed as an internal tool for managing employees within an organization. Given its internal use case, the application does not include a registration feature, password hashing or even authorization. It's not a big app, but it's kinda better than excel. 😛 Just joking!

### Access Credentials

- **Email:** admin@email.com
- **Password:** admin

## Front-End Repository

The front-end for this backend application can be found at the following GitHub repository:

[Employee Management Client](https://github.com/constantinrazvan/EmployeeManagementClient.git)

## Features

- **Employee Management:** Add, update, delete, and view employee details.
- **Access:** Just a prebuilt account for access.

## Technologies Used

- **Backend:** ASP.NET Core, Entity Framework Core
- **Frontend:** Angular
- **Database:** SQL Server

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Node.js](https://nodejs.org/) (for running the Angular front-end)
- [Angular CLI](https://angular.io/cli) (for managing Angular projects)

### Setup Instructions

#### Back-end

1. **Clone the back-end repository:**
   ```bash
   cd Desktop
   git clone https://github.com/constantinrazvan/Employee-Management.git
   cd Employee-Management
   dotnet run
   ```

2. **Update the connection string:** 
    In appsettings.json, update the connection string to point to your SQL Server instance.

3. **Apply migrations and seed the database:** 
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```
4. **Run the backend application:**
    ```bash
    dotnet run
    ```

#### Front-end

1. **Clone the front-end repository:**
    ```bash
    git clone https://github.com/constantinrazvan/EmployeeManagementClient.git
    cd EmployeeManagementClient
    ```

2. **Install dependencies:**
    ```bash
    npm install
    ```
3. **Run the frontend application:**
    ```bash
    ng serve 
    ```

#### Usage
1.  **Login:**
    Use the provided credentials to log in:
    Email: admin@email.com
    Password: admin

2.  **Manage Employees:**
    Once logged in, you can add, update, delete, and view employees through the front-end interface.