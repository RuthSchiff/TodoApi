# TodoApi

This is a Todo API project built with ASP.NET Core and Entity Framework Core. The API allows users to register, login, and manage their tasks.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [MySQL](https://www.mysql.com/downloads/)
- [Git](https://git-scm.com/downloads)

## Getting Started

1. Clone the repository:

   ```sh
   git clone https://github.com/RuthSchiff/TodoApi.git
   cd TodoApi
   Create a .env file in the root directory with the following content:

1 vulnerability
Install the required NuGet packages:

Apply the database migrations:

Run the application:

Open your browser and navigate to http://localhost:5000/swagger to view the Swagger UI.

API Endpoints
User Registration
Endpoint: /register/{Name}/{Password}
Method: POST
Description: Registers a new user.
Parameters:
Name (string): The name of the user.
Password (string): The password of the user.
User Login
Endpoint: /login/{password}
Method: POST
Description: Logs in a user.
Parameters:
password (string): The password of the user.
Get All Tasks
Endpoint: /allTasks
Method: GET
Description: Retrieves all tasks for a specific user.
Parameters:
userId (int): The ID of the user.
Add Task
Endpoint: /addTask/{NameT}/{userId}
Method: POST
Description: Adds a new task for a specific user.
Parameters:
NameT (string): The name of the task.
userId (int): The ID of the user.
Delete Task
Endpoint: /deleteTask/{id}
Method: DELETE
Description: Deletes a task by ID.
Parameters:
id (int): The ID of the task.
Update Task
Endpoint: /updateTask/{id}
Method: PUT
Description: Updates the completion status of a task by ID.
Parameters:
id (int): The ID of the task.
Project Structure
Program.cs: The main entry point of the application.
ToDoDbContext.cs: The Entity Framework Core database context.
Models/: Contains the data models for the application.
Controllers/: Contains the API controllers.
Contributing
If you would like to contribute to this project, please fork the repository and submit a pull request.

License
This project is licensed under the MIT License. See the LICENSE file for more details.

# TodoApi

זהו פרויקט API לניהול משימות שנבנה עם ASP.NET Core ו-Entity Framework Core. ה-API מאפשר למשתמשים להירשם, להתחבר ולנהל את המשימות שלהם.

## דרישות מקדימות

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [MySQL](https://www.mysql.com/downloads/)
- [Git](https://git-scm.com/downloads)

## התחלת עבודה

1. שיבוט המאגר:

   ```sh
   git clone https://github.com/RuthSchiff/TodoApi.git
   cd TodoApi
   צור קובץ .env בתיקיית השורש עם התוכן הבא:

1 vulnerability
התקן את חבילות ה-NuGet הנדרשות:

החל את המיגרציות של מסד הנתונים:

הרץ את האפליקציה:

פתח את הדפדפן שלך ונווט ל-http://localhost:5000/swagger כדי לצפות ב-Swagger UI.

נקודות קצה של ה-API
רישום משתמש
נקודת קצה: /register/{Name}/{Password}
שיטה: POST
תיאור: רושם משתמש חדש.
פרמטרים:
Name (string): שם המשתמש.
Password (string): סיסמת המשתמש.
התחברות משתמש
נקודת קצה: /login/{password}
שיטה: POST
תיאור: מתחבר משתמש.
פרמטרים:
password (string): סיסמת המשתמש.
קבלת כל המשימות
נקודת קצה: /allTasks
שיטה: GET
תיאור: מחזיר את כל המשימות של משתמש מסוים.
פרמטרים:
userId (int): מזהה המשתמש.
הוספת משימה
נקודת קצה: /addTask/{NameT}/{userId}
שיטה: POST
תיאור: מוסיף משימה חדשה למשתמש מסוים.
פרמטרים:
NameT (string): שם המשימה.
userId (int): מזהה המשתמש.
מחיקת משימה
נקודת קצה: /deleteTask/{id}
שיטה: DELETE
תיאור: מוחק משימה לפי מזהה.
פרמטרים:
id (int): מזהה המשימה.
עדכון משימה
נקודת קצה: /updateTask/{id}
שיטה: PUT
תיאור: מעדכן את סטטוס ההשלמה של משימה לפי מזהה.
פרמטרים:
id (int): מזהה המשימה.
מבנה הפרויקט
Program.cs: נקודת הכניסה הראשית של האפליקציה.
ToDoDbContext.cs: הקונטקסט של Entity Framework Core.
Models/: מכיל את המודלים של הנתונים של האפליקציה.
Controllers/: מכיל את בקרי ה-API.
תרומה
אם ברצונך לתרום לפרויקט זה, אנא בצע fork למאגר והגש pull request.

רישיון
פרויקט זה מורשה תחת רישיון MIT. ראה את קובץ LICENSE לפרטים נוספים.

באמצעות קובץ .gitignore זה, תוכל להבטיח שמידע רגיש וקבצים זמניים לא יועלו ל-Git, מה שיסייע לשמור על הפרויקט שלך בטוח ונקי.

