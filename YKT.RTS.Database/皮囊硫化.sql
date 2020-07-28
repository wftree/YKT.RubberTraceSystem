CREATE TABLE [dbo].[皮囊硫化]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [产品型号] NVARCHAR(200) NOT NULL, 
    [生产机台] UNIQUEIDENTIFIER NOT NULL,
    [作业员] UNIQUEIDENTIFIER NOT NULL, 
    [成型皮囊] UNIQUEIDENTIFIER NOT NULL, 
    [硫化温度] float NULL, 
    [硫化时间] float NULL, 
    [模具] UNIQUEIDENTIFIER NULL, 
    [生产时间] DATETIME DEFAULT getdate(),
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_皮囊硫化_机台] FOREIGN KEY (生产机台) REFERENCES 机台(Id), 
    CONSTRAINT [FK_皮囊硫化_员工] FOREIGN KEY (作业员) REFERENCES 员工(Id), 
    CONSTRAINT [FK_皮囊硫化_成型皮囊] FOREIGN KEY (成型皮囊) REFERENCES 皮囊成型(Id),

)
