## Stock Financial Data Viewer and Portfolio Manager
The backend project with the database is hosted on https://financemanager.runasp.net and the api documentation can be seen on [https://financemanager.runasp.net/swagger/index.html](https://financemanager.runasp.net/swagger/index.html)
This is the backend API for the Stock Financial Data Viewer application, developed using .NET Web API. 
It provides endpoints for user authentication, managing personal portfolios, and fetching financial data 
from an AWS RDS-hosted Microsoft SQL Server database. This API serves as the backend for the frontend React.js application. [React Project](https://github.com/bipan1/Finance-Project)

## Features
- User Management: Endpoints for user registration, login, and profile management.
- Portfolio Management: Endpoints to create, update, delete, and view stock portfolios.
- Data Fetching: Fetches real-time and historical financial data from the AWS RDS-hosted SQL Server database.
- Secure Authentication: Uses JWT for secure user authentication and authorization.
- Robust Error Handling: Comprehensive error handling for all API requests.
- Scalable Architecture: Designed to handle a large number of requests and scale as needed.

## Technologies Used
- .NET Web API: A framework for building HTTP services that can be accessed from various clients.
- C#: The programming language used to develop the API.
- Microsoft SQL Server: A relational database hosted on AWS RDS for data storage.
- Entity Framework Core: An ORM (Object-Relational Mapper) for data access.
- JWT (JSON Web Tokens): For secure user authentication and authorization.
- AWS RDS: Amazon Web Services Relational Database Service, hosting the SQL Server database.
- ASP.NET Core Middleware: For handling requests, logging, and error handling.

## Deployment
The Microsoft SQL server database and the .NET web app project are hosted on [https://www.monsterasp.net/](https://www.monsterasp.net/). They provide a straightforward and efficient way to deploy your .NET app with a database for free. 
