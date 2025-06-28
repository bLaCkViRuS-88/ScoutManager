# Material Management App

## Overview
The Material Management App is a web application designed for managing materials for a scout group. It allows users to view, add, and manage materials efficiently.

## Features
- List all materials
- View details of each material
- User-friendly interface

## Project Structure
```
MaterialManagementApp
├── Controllers
│   └── MaterialsController.cs
├── Models
│   └── Material.cs
├── Views
│   ├── Materials
│   │   ├── Index.cshtml
│   │   └── Details.cshtml
│   └── Shared
│       └── _Layout.cshtml
├── wwwroot
│   └── css
│       └── site.css
├── appsettings.json
├── Program.cs
├── Startup.cs
└── README.md
```

## Setup Instructions
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```
   cd MaterialManagementApp
   ```
3. Restore the dependencies:
   ```
   dotnet restore
   ```
4. Run the application:
   ```
   dotnet run
   ```
5. Open your web browser and navigate to `http://localhost:5000` to access the application.

## Technologies Used
- ASP.NET Core
- Razor Pages
- Entity Framework Core (if applicable)
- CSS for styling

## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.