
# Sports Club

## Overview
Sports Club is a .NET web application designed to manage fan and sports club registrations. It utilizes Azure Blob Storage for storing news-related media, Entity Framework Core for data persistence, LINQ for data querying, and Azure Cloud for hosting and deployment.

## Demo 

https://github.com/REAPERali00/SportsClub/assets/120317445/bb2542fb-5de1-4cc0-823a-90d5d5001e1c

## Features

- **Fan and Club Registration**: Securely register and manage fan and club information using a robust database system.
- **News Management**: Utilize Azure Blob Storage to upload, store, and manage news-related multimedia content.
- **Data Querying**: Efficiently fetch data using LINQ queries directly integrated into the platform.
- **URL Routing**: Implement controller-based routing to handle and respond to web requests seamlessly.

## Prerequisites

- .NET 5.0 SDK or later
- Azure subscription
- SQL Server or Azure SQL Database
- Azure Storage Account

## Setup and Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/sportsclub.git
   cd sportsclub
   ```

2. **Database Setup**
   - Ensure SQL Server is installed and running.
   - Update the connection string in `appsettings.json`.

3. **Azure Blob Storage Configuration**
   - Create a Blob Storage account through your Azure portal.
   - Update the storage connection string in `appsettings.json`.

4. **Running the Application**

   - Execute the following command to run the application:

     ```bash
     dotnet run
     ```

## Deployment
- This application is configured for deployment on Azure Cloud. Follow the Azure deployment guidelines to set up CI/CD pipelines and deploy the application.

## Contributing
Contributions are welcome! Please read our contributing guidelines to get started on your contributions.

## License
This project is licensed under the MIT License - see the LICENSE file for details.
