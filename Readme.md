# -- 🔐🛠 User Management System Project 🛠🔐 --


This project focuses on creating a User Management System using ASP.NET and SQL Server. Below is a summary of the key aspects covered:

### Database Structure:

A SQL Server database named datamaster was designed with a Users table containing the following fields:


UserId (INT, auto-incremental): Unique identifier for the user.

Nombre (NVARCHAR): User's first name.

apellido (NVARCHAR): User's last name.

telefono (NVARCHAR): User's phone number.

ciudad (NVARCHAR): User's city.

mes (INT): A number representing the month in some way.

ventames (DECIMAL): User's sales amount for the month.


### Database Connection
Connection details to the database were provided:

SQL SERVER IP: 107.161.
180.122,1433

User: qbpruebaDSR

Password: W7s4@jcEjdo2lwWEeO2Jf

The connection string to connect to SQL Server is:

```http
Server=107.161.180.122,1433;Database=datamaster;User Id=qbpruebaDSR;Password=W7s4@jcEjdo2lwWEeO2Jf;
```


### User Class in ASP.NET
An ASP.NET User class was implemented, containing methods to perform CRUD operations on the database:

grid_usuarios: Populates a GridView with data from the database.

AgregarUsuario: Adds a new user to the database.

ModificarUsuario: Modifies an existing user in the database.

EliminarUsuario: Deletes a user from the database.

DropDownList for Months
A method was implemented to manage a DropDownList with the names of the months. Additionally, a function was created to convert the month's name to its respective number.

ASP.NET View
An ASP.NET view was created using the User class to interact with the database. Methods were implemented to add, modify, and delete users. Additionally, a GridView was included to visualize user information.


finally i want to give us the thaks for the oportunity. i apreciated that. :)

## Tecnologies has been used

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain.svg" height="40" alt="microsoftsqlserver logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg" height="40" alt="visualstudio logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dot-net/dot-net-original.svg" height="40" alt="dot-net logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="40" alt="csharp logo"  />
</div>

###

###
</div>




## Support

For additional support and inquiries, please email angelgabrielorteg@gmail.com or send me request via discord.🥰!


## Authors

- [@Angel-ISO](https://www.github.com/Angel-ISO)