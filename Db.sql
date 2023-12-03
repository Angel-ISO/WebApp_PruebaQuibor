CREATE DATABASE datamaster;

USE datamaster;

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(255),
    apellido NVARCHAR(255),
    telefono NVARCHAR(15),
    ciudad NVARCHAR(255),
    mes INT,
    ventames DECIMAL(12,2)
);