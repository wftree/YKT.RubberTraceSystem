CREATE TABLE [dbo].[胶料入库]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [胶料牌号] NCHAR(200) NOT NULL, 
    [箱号] NCHAR(200), 
    [生产线号] NCHAR(200), 
    [供应商产品代号] NCHAR(200), 
    [生产日期] NCHAR(200) NOT NULL, 
    [批次号] NCHAR(200) NOT NULL, 
    [重量] FLOAT NOT NULL, 
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0
)
