# 📚 Library Management System - Backend API

A robust and scalable backend API for the Library Management System built with ASP.NET Core 8.0, featuring RESTful endpoints for efficient book management.

## ✨ Features

### � Book Management API

- **Create Books**:
  - Endpoint: POST /api/books
  - Validates book data
  - Stores book information in SQLite database
  - Returns newly created book with ID

- **Read Books**:
  - Get all books: GET /api/books
  - Get single book: GET /api/books/{id}
  - Efficient data retrieval
  - Pagination support

- **Update Books**:
  - Endpoint: PUT /api/books/{id}
  - Full book information update
  - Validation of update data
  - Returns updated book information

- **Delete Books**:
  - Endpoint: DELETE /api/books/{id}
  - Safe deletion with validation
  - Proper status code responses

## 🛠️ Technology Stack

- **Framework**: ASP.NET Core 8.0
- **Database**: SQLite with Entity Framework Core
- **API Documentation**: Swagger
- **ORM**: Entity Framework Core
- **Development Platform**: .NET 8.0
- **API Architecture**: REST

## 📦 Project Structure

```
├── Controllers/           # API Controllers
│   └── BooksController.cs # Handles book-related endpoints
├── Models/               # Data Models
│   ├── Book.cs          # Book entity model
│   ├── AddBookDto.cs    # DTO for adding books
│   └── UpdateBookDto.cs # DTO for updating books
├── Data/                # Database Context
│   └── ApplicationDbContext.cs
├── Migrations/          # Database Migrations
└── Properties/          # Launch Settings
```

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022 or VS Code
- Git

### Installation

1. Clone the repository:
```bash
git clone https://github.com/charithasekara/LibraryManagement-Backend.git
```

2. Navigate to project directory:
```bash
cd LibraryManagement-Backend
```

3. Restore dependencies:
```bash
dotnet restore
```

4. Apply database migrations:
```bash
dotnet ef database update
```

5. Run the application:
```bash
dotnet run
```

The API will be available at `https://localhost:7036`

### Using Visual Studio
1. Open `backend.sln` in Visual Studio
2. Restore NuGet packages
3. Press F5 to run the application

### API Documentation
Once the application is running, you can access the Swagger documentation at:
`https://localhost:7036/swagger`

## 🎯 API Endpoints

### Books API
- **GET /api/books**
  - Retrieves all books
  - Optional query parameters for pagination
  - Returns: Array of book objects

- **GET /api/books/{id}**
  - Retrieves a specific book by ID
  - Returns: Single book object
  - 404 if book not found

- **POST /api/books**
  - Creates a new book
  - Required fields: title, author
  - Returns: Created book object with ID

- **PUT /api/books/{id}**
  - Updates an existing book
  - Requires full book object
  - Returns: Updated book object

- **DELETE /api/books/{id}**
  - Deletes a book
  - Returns: 204 No Content
  - 404 if book not found

### Error Handling
- Proper HTTP status codes
- Detailed error messages
- Validation error responses
- Global exception handling

## 🔧 Configuration

The application uses the following configuration in `appsettings.json`:
- Database connection string (SQLite)
- CORS policy settings
- Swagger/OpenAPI settings

## 🔒 Security

- CORS is configured to allow requests from the frontend application
- Input validation on all endpoints
- Entity Framework Core for SQL injection prevention
- Prepared for JWT authentication implementation

## 🧪 Testing

Run the tests using:
```bash
dotnet test
```

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👏 Acknowledgments

- ASP.NET Core team for the amazing framework
- Entity Framework Core team
- SQLite team for the lightweight database