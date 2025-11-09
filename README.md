# Textile Database Management System

**Course:** Database Systems / 3rd Semester  
**Project Type:** Desktop Application (C#) + SQL Server 2022  

## Team Members  
- Azeem Mohamed Husain — B22F0759CS142  
- Faththima Misna — B22F0757AI142  

## Project Overview  
This is a textile business-oriented database management system built using C# (Windows Forms) and Microsoft SQL Server 2022.  
It allows managing inventory (textile products), suppliers, customers, sales/invoices, and reporting of data stored in a relational database.

## Features  
- User login/registration and role-based access (e.g., admin vs user)  
- Inventory management: add, update, delete textile products  
- Supplier & customer management  
- Sales transactions, invoices generation  
- Database operations: insert, update, delete, select queries, and basic reporting  
- Simple GUI built using Windows Forms in C#  

## Technologies Used  
- C# (Windows Forms)  
- Visual Studio (version X)  
- Microsoft SQL Server 2022  
- ADO.NET or Entity Framework (if used)  
- Database files or script to recreate the schema  

## Setup Instructions  

### 1. Database Setup  
1. Open SQL Server Management Studio (SSMS)  
2. Create a new database, e.g., `TextileDB`  
3. Restore the database using the `.mdf`/`.ldf` files contained in `/Database` folder **OR** execute the SQL script file (`textile_db_script.sql`) if provided.  
4. Ensure the connection string in the C# application points to your SQL Server instance and database name.

### 2. Application Setup  
1. Open the solution file `WindowsFormsApp1.sln` in Visual Studio.  
2. Build the project to restore any dependencies.  
3. Run the application.  
4. Log in using the default credentials (if provided) or create a new user.  
5. Navigate through the application and test adding products, sales, customers, etc.

## Folder Structure  
/Textile-Database-Management-System
│
├─ /WindowsFormsApp1/ – C# project files
├─ /Database/ – .mdf & .ldf files or SQL script
├─ /DB project related images/ – Screenshots, logos, etc
├─ README.md – This file
├─ .gitignore – Excludes bin/, obj/, etc

## Notes  
- This system is built for educational purposes and does not include production-level security or concurrency features.  
- You may need to modify the connection string in `App.config` or `Program.cs` depending on your SQL Server instance name.

## License  
MIT License  
Feel free to use, modify and learn from this project.

