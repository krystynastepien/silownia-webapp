
IF DB_ID('DB_FitBit') IS NULL
-- Code for SQL Create Database
CREATE DATABASE DB_FitBit


If OBJECT_ID('USERS', 'U') IS NULL
CREATE TABLE dbo.USERS(
	u_Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- Autoinkrementacja o 1, nie moze byc null, Klucz g��wny
	u_Name VARCHAR(20) NOT NULL,-- CHECK (u_Name LIKE '[A-Z]%'),
	u_LastName VARCHAR(30) NOT NULL, -- CHECK (u_LastName LIKE '[A-Z]%'),
	u_Email VARCHAR(40) NOT NULL,
	u_Username Varchar(20) NOT NULL,
	u_Password Varchar(100) NOT NULL,
)


GO
-- ---------------------------------------------------------------------------