CREATE TABLE [dbo].[胶料入库]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [胶料牌号] NVARCHAR(200) NOT NULL, 
    [箱号] NVARCHAR(200), 
    [生产线号] NVARCHAR(200), 
    [供应商产品代号] NVARCHAR(200), 
    [生产日期] DATETIME NOT NULL, 
    [批次号] NVARCHAR(200) NOT NULL, 
    [重量] FLOAT(2) NOT NULL, 
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0, 
    [消耗结束] BIT NOT NULL default 0, 
    [出库时间] DATETIME NOT NULL DEFAULT getdate()
)
