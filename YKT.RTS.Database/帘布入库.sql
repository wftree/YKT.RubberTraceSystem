CREATE TABLE [dbo].[帘布入库]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [帘布代号] NCHAR(200) NOT NULL, 
    [胶料] NCHAR(200), 
    [帘布长度] FLOAT NOT NULL, 
    [生产序号] FLOAT NULL, 
    [生产日期] DATETIME NOT NULL, 
    [有效日期] DATETIME NOT NULL, 
    [重量] FLOAT NOT NULL, 
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0, 

)
