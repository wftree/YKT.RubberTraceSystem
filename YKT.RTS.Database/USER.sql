﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryId] INT NOT NULL, 
    [Name] NVARCHAR(10) NOT NULL, 
    [MD5] NVARCHAR(32) NULL, 
    CONSTRAINT [FK_User_ToTCategory] FOREIGN KEY (CategoryId) REFERENCES Category(Id)
)
