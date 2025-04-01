--drop table Transactions;
--drop table Books;
--drop table Users;
--drop table Authors;
--drop table Categories;
--drop table Publishers;
--drop table Supplier;
CREATE TABLE Users (
  UserId INT PRIMARY KEY IDENTITY(1, 1),
  Username VARCHAR(100) NOT NULL UNIQUE,
  PASSWORD VARCHAR(255) NOT NULL,
  Role VARCHAR(100) NOT NULL -- Admin, Employee, Guest
);

CREATE TABLE Authors (
  AuthorId INT PRIMARY KEY IDENTITY(1, 1),
  FirstName VARCHAR(255) NOT NULL,
  LastName VARCHAR(255) NOT NULL
);

CREATE TABLE Categories (
  CategoryId INT PRIMARY KEY IDENTITY(1, 1),
  CategoryName VARCHAR(255) NOT NULL
);

CREATE TABLE Publishers (
  PublisherId INT PRIMARY KEY IDENTITY(1, 1),
  Name VARCHAR(255) NOT NULL,
  Phone VARCHAR(255) NOT NULL,
  Address VARCHAR(255),
  ContactPerson VARCHAR(255)
);

CREATE TABLE Supplier (
  SupplierId INT PRIMARY KEY IDENTITY(1, 1),
  Name VARCHAR(255) NOT NULL,
  Phone VARCHAR(255) NOT NULL,
  Address VARCHAR(255),
  ContactPerson VARCHAR(255)
);

CREATE TABLE Books (
  ISBN BIGINT PRIMARY KEY,
  Title VARCHAR(255) NOT NULL,
  RetailPrice DECIMAL(10, 2) NOT NULL,
  StockCount INT NOT NULL DEFAULT 0,
  StockStatus VARCHAR(50) NOT NULL,
  -- Out-of-stock, low-stock, in-stock
  AuthorId INT NOT NULL,
  CategoryId INT NOT NULL,
  PublisherId INT NOT NULL,
  FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId),
  FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId),
  FOREIGN KEY (PublisherId) REFERENCES Publishers(PublisherId)
);

CREATE TABLE Transactions (
  Id INT PRIMARY KEY IDENTITY(1, 1),
  ISBN BIGINT,
  Count INT NOT NULL,
  Date DATE NOT NULL,
  BuyPrice DECIMAL(10, 2) NOT NULL DEFAULT 0,
  UserId INT NOT NULL,
  Description VARCHAR(255),
  SupplierId INT,
  FOREIGN KEY (ISBN) REFERENCES Books(ISBN),
  FOREIGN KEY (UserId) REFERENCES Users(UserId),
  FOREIGN KEY (SupplierId) REFERENCES Supplier(SupplierId)
);