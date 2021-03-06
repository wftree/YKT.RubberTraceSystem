﻿CREATE TABLE [dbo].[员工]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [姓名] NVARCHAR(200) NOT NULL, 
    [班别] UNIQUEIDENTIFIER not null,
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_员工_班别] FOREIGN KEY (班别) REFERENCES 班别(Id)
)
