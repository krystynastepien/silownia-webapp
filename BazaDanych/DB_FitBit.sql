USE [master]
GO

/****** Object:  Database [DB_FitBit]    Script Date: 16.01.2020 14:11:32 ******/
CREATE DATABASE [DB_FitBit]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_FitBit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_FitBit.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_FitBit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_FitBit_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_FitBit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DB_FitBit] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DB_FitBit] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DB_FitBit] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DB_FitBit] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DB_FitBit] SET ARITHABORT OFF 
GO

ALTER DATABASE [DB_FitBit] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [DB_FitBit] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DB_FitBit] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DB_FitBit] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DB_FitBit] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DB_FitBit] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DB_FitBit] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DB_FitBit] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DB_FitBit] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DB_FitBit] SET  ENABLE_BROKER 
GO

ALTER DATABASE [DB_FitBit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DB_FitBit] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DB_FitBit] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DB_FitBit] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DB_FitBit] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DB_FitBit] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [DB_FitBit] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DB_FitBit] SET RECOVERY FULL 
GO

ALTER DATABASE [DB_FitBit] SET  MULTI_USER 
GO

ALTER DATABASE [DB_FitBit] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DB_FitBit] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DB_FitBit] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DB_FitBit] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [DB_FitBit] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [DB_FitBit] SET QUERY_STORE = OFF
GO

ALTER DATABASE [DB_FitBit] SET  READ_WRITE 
GO

