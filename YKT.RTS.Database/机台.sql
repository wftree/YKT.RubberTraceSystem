CREATE TABLE [dbo].[机台]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [机台编号] NCHAR(200) NOT NULL, 
    [机台名称] NCHAR(200),
    [机台描述] NCHAR(200),
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0
)
