# Online Examination Portal - ASP.NET Core MVC

## Project Overview

This ASP.NET Core MVC project demonstrates Session Management, Cookies, Filters, Authentication Validation, and Logging using an Online Examination Portal case study.

The application focuses on maintaining login sessions, restricting unauthorized access, storing user preferences, and tracking user activities.

---

## Features

✅ Session Management  
✅ Cookie Handling  
✅ MVC Filters  
✅ Custom Authentication Filter  
✅ Logging Mechanism  
✅ Unauthorized Access Restriction  
✅ User Input Forms  

---

## Technologies Used

- ASP.NET Core MVC
- C#
- Razor Views
- .NET 8

---

## Project Modules

Controllers:
- AccountController
- DashboardController

Filters:
- LoggingFilter
- AuthFilter

Views:
- Login
- Dashboard

---

## Functionalities

### Session Management

Stores:
- Student Name
- Course Information

### Cookies

Stores:
- Theme Preference

### Authentication Filter

Restricts access to dashboard page without login.

### Logging

Tracks:
- Action Execution
- Login Activity

---

## Sample Output

### Login Page

User Inputs:
- Student Name
- Course
- Theme Selection

### Dashboard Page

Displays:
- Logged-in Student Name
- Course Name
- Selected Theme
- Portal Features

---

## Security Features

- Session-based login handling
- Unauthorized access prevention
- Reusable authentication filter
- Centralized logging

---

## Best Practices Used

- Lightweight cookie storage
- Session clearing during logout
- Reusable filters
- Centralized logging
- Clean MVC Architecture

---

## How To Run

1. Open project in Visual Studio
2. Restore NuGet packages
3. Run using Ctrl + F5

---

## Learning Outcomes

- Understand Session Management
- Implement Cookies
- Create MVC Filters
- Apply Custom Authentication
- Implement Logging in ASP.NET Core MVC
