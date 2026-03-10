# Employee Payroll System

## Project Overview

The **Employee Payroll System** is a simple desktop application developed using **C# WinForms** and **Microsoft SQL Server**.
The purpose of this project is to manage employee information and calculate monthly salaries based on the number of leaves taken.

The system allows users to:

* Add and manage employee records
* Generate payroll for a specific month
* Calculate salary deductions based on leaves
* Display salary reports

This project demonstrates basic concepts of **desktop application development**, **database connectivity**, and **data management using SQL**.

---

# Objective

The main objective of this project is to create a basic payroll management system that helps in:

* Storing employee information
* Automatically calculating salary deductions
* Generating monthly payroll records
* Displaying payroll reports

The system is designed for learning purposes and demonstrates how **C# applications interact with SQL databases**.

---

# Technologies Used

| Technology | Purpose                          |
| ---------- | -------------------------------- |
| C#         | Application programming language |
| WinForms   | Desktop User Interface           |
| SQL Server | Database management              |
| ADO.NET    | Database connection and queries  |
| VS Code    | Development environment          |
| .NET SDK   | Application runtime              |

---

# Project Features

### 1. Add Employee

Users can add new employee records by entering:

* Employee Name
* Department
* Basic Salary

---

### 2. Manage Employees

The system displays all employees in a **DataGridView table** where users can:

* View employee details
* Edit employee information
* Delete employees

---

### 3. Generate Payroll

The payroll module allows the user to:

* Select an employee
* Enter the month
* Enter number of leaves

The system automatically calculates the final salary after deductions.

---

### 4. Salary Calculation

The salary is calculated based on the following logic:

Daily Salary = BasicSalary / 30

Salary Deduction = DailySalary × Leaves

Final Salary = BasicSalary − Deduction

Example:

Basic Salary: 30000
Leaves: 2

Daily Salary = 30000 / 30 = 1000

Deduction = 1000 × 2 = 2000

Final Salary = 28000

---

# Database Design

## Employees Table

| Column      | Description                      |
| ----------- | -------------------------------- |
| EmployeeID  | Unique employee ID (Primary Key) |
| Name        | Employee name                    |
| Department  | Department name                  |
| BasicSalary | Monthly salary of employee       |

SQL:

```sql
CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Department NVARCHAR(100),
    BasicSalary DECIMAL(10,2)
);
```

---

## Payroll Table

| Column      | Description                  |
| ----------- | ---------------------------- |
| PayrollID   | Unique payroll record ID     |
| EmployeeID  | Foreign key linking employee |
| Month       | Payroll month                |
| Leaves      | Number of leave days         |
| FinalSalary | Salary after deduction       |

SQL:

```sql
CREATE TABLE Payroll
(
    PayrollID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT,
    Month NVARCHAR(50),
    Leaves INT,
    FinalSalary DECIMAL(10,2)
);
```

---

# Project Structure

```
PayrollSystem
│
├── Forms
│   ├── DashboardForm.cs
│   ├── AddEmployeeForm.cs
│   ├── EmployeeListForm.cs
│   ├── PayrollForm.cs
│   └── ReportsForm.cs
│
├── Models
│   ├── Employee.cs
│   └── Payroll.cs
│
├── Database
│   └── DatabaseHelper.cs
│
├── Program.cs
└── PayrollSystem.csproj
```

---

# System Workflow

1. User adds an employee to the system.
2. Employee data is stored in the **Employees table**.
3. The user generates payroll for a specific month.
4. Leaves are entered.
5. The system calculates the **final salary**.
6. Payroll records are stored in the **Payroll table**.
7. Reports can be viewed in the application.

---

# Concepts Learned

This project helps students understand:

* C# WinForms application development
* Database connectivity using ADO.NET
* SQL database design
* SQL joins
* DataGridView for displaying data
* Form validation
* Basic salary calculation logic

---

# Requirements

To run this project, the following software must be installed:

* .NET SDK
* Visual Studio Code
* C# Extension for VS Code
* SQL Server
* SQL Server Management Studio (SSMS)

---

# How to Run the Project

1. Clone or download the repository.

2. Open the project folder in **VS Code**.

3. Restore dependencies.

```
dotnet restore
```

4. Run the application.

```
dotnet run
```

5. Make sure SQL Server is running and the **PayrollDB database** is created.

---


# Conclusion

The Employee Payroll System is a simple desktop application designed to demonstrate how **C# applications interact with SQL databases**.
It provides a basic solution for managing employee records and calculating payroll while helping students understand core programming and database concepts.

---

# Author

Shaiaan, Faizan
Course: GIT
