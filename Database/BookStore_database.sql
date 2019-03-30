CREATE DATABASE BookStore;

USE BookStore;

create table Accounts(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(255) NULL,
	Email NVARCHAR(255) NULL,
	Password NVARCHAR(255) NULL,
	Username NVARCHAR(255) NULL,
	RoleId INT NOT NULL DEFAULT((0)),
	UserType NVARCHAR(1) NOT NULL DEFAULT((0)),
	Status NVARCHAR(2) DEFAULT((1)),
	CreateAt DATETIME NOT NULL DEFAULT(getdate()),
	UpdateAt DATETIME NOT NULL DEFAULT(getdate()),
)