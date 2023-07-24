
Description
This project is a .NET 5 implemented Blazor WebAssembly application for managing tasks.

TodoList enables communication with the MSSQL database consisting of sending and receiving data regarding users, lists and todos. Application can be used by users who may create account and login to the application.

Stack
It uses Entity Framework Core to communicate with a database, which contains required data tables like:

Users - where informations about users are stored
ListsOfTodos - where informations about lists of todos are stored
Todos- where informations about todos are stored.
Other tools used in project:

JwtBearer - for authentication
Open API - for API documentation
AutoMapper - for mapping DTO-s and EntityModels data

**Configuration for mssql database

This will need to be performed before running the application for the first time

--You have to change ConnectionString in appsettings.json for ConnectionString that allow you to connect with database in your computer.
--Issue the Entity Framework command to update the database
	Open Package Manager Console in Visual Studio and run the following commands:
	dotnet tool install --global dotnet-ef --version 5.*
	cd TodList
	dotnet ef database update
