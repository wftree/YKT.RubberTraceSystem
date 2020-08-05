CREATE TABLE [dbo].[帘布入库]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [帘布代号] NVARCHAR(200) NOT NULL, 
    [胶料] NVARCHAR(200), 
    [帘布长度] FLOAT(2) NOT NULL, 
    [生产序号] FLOAT(2) NULL, 
    [生产日期] DATETIME NOT NULL, 
    [有效日期] DATETIME NOT NULL, 
    [重量] FLOAT(2) NULL, 
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0, 
    [消耗结束] BIT NOT NULL default 0, 
    [出库时间] DATETIME NOT NULL DEFAULT getdate()

)
