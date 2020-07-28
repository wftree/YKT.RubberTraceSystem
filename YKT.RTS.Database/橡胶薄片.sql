CREATE TABLE [dbo].[橡胶薄片]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [宽度] FLOAT NOT NULL, 
    [厚度] FLOAT NOT NULL, 
    [数量] FLOAT NOT NULL, 
    [作业员] UNIQUEIDENTIFIER NOT NULL, 
    [胶料批号] UNIQUEIDENTIFIER NOT NULL, 
    [生产序号] FLOAT NOT NULL, 
    [生产时间] DATETIME default getdate(), 
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0, 
        [消耗结束] BIT NOT NULL default 0, 
    [出库时间] DATETIME NOT NULL DEFAULT getdate()
    CONSTRAINT [FK_橡胶薄片_员工] FOREIGN KEY (作业员) REFERENCES 员工(Id),
    [消耗重量] FLOAT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_橡胶薄片_胶料入库] FOREIGN KEY (胶料批号) REFERENCES 胶料入库(Id)
)
