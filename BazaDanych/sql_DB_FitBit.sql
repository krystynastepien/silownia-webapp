
IF DB_ID('DB_FitBit') IS NULL
-- Code for SQL Create Database
CREATE DATABASE DB_FitBit

USE DB_FitBit
GO

If OBJECT_ID('USERS', 'U') IS NULL
CREATE TABLE dbo.USERS(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- Autoinkrementacja o 1, nie moze byc null, Klucz g³ówny
	Name VARCHAR(20) NOT NULL,-- CHECK (u_Name LIKE '[A-Z]%'),
	LastName VARCHAR(30) NOT NULL, -- CHECK (u_LastName LIKE '[A-Z]%'),
	Email VARCHAR(40) NOT NULL,
	Username Varchar(20) NOT NULL,
	Password Varchar(100) NOT NULL,
);


--INSERT INTO USERS (Name, LastName, Email, Username, Password)
--VALUES ('John', 'Doe', 'john@gmail.com', 'admin', 'admin')
--VALUES ('Ellie', 'Doe', 'john@gmail.com', 'admin', 'admin')
--VALUES ('Jaskier', 'Hh', 'jaskier@gmail.com', 'jask', 'jask2')

Select * from USERS
--DELETE FROM USERS WHERE Username='admin';
-- ---------------------------------------------------------------------------