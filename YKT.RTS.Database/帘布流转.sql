CREATE TABLE [dbo].[帘布流转]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [产品编号] NVARCHAR(200) NOT NULL, 
    [宽度] FLOAT NOT NULL, 
    [厚度] FLOAT NOT NULL, 
    [角度] FLOAT NOT NULL, 
    [作业员] UNIQUEIDENTIFIER NULL, 
    [生产时间] DATETIME default getdate(), 
    [帘布批号] UNIQUEIDENTIFIER NOT NULL, 
    [使用期限] DATETIME NOT NULL, 
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0,
        [消耗结束] BIT NOT NULL default 0, 
    [出库时间] DATETIME NOT NULL DEFAULT getdate()
    CONSTRAINT [FK_帘布流转_员工] FOREIGN KEY (作业员) REFERENCES 员工(Id),
    [数量] FLOAT NOT NULL default 0, 
    [消耗数量] FLOAT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_帘布流转_帘布入库] FOREIGN KEY (帘布批号) REFERENCES 帘布入库(Id)
)
