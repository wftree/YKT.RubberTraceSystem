﻿CREATE TABLE [dbo].[皮囊成型]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [产品型号] NCHAR(200) NOT NULL, 
    [生产机台] UNIQUEIDENTIFIER NULL,
    [作业员] UNIQUEIDENTIFIER NULL, 
    [帘布批号] UNIQUEIDENTIFIER NOT NULL, 
    [外胶片批号] UNIQUEIDENTIFIER NOT NULL, 
    [内胶片批号] UNIQUEIDENTIFIER NOT NULL, 
    [登记时间] DATETIME NOT NULL DEFAULT getdate(), 
    [删除] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_皮囊成型_机台] FOREIGN KEY (生产机台) REFERENCES 机台(Id), 
    CONSTRAINT [FK_皮囊成型_员工] FOREIGN KEY (作业员) REFERENCES 员工(Id), 
    CONSTRAINT [FK_皮囊成型_帘布流转] FOREIGN KEY (帘布批号) REFERENCES 帘布流转(Id),
    CONSTRAINT [FK_皮囊成型_内橡胶薄片] FOREIGN KEY (内胶片批号) REFERENCES 橡胶薄片(Id),
    CONSTRAINT [FK_皮囊成型_外橡胶薄片] FOREIGN KEY (外胶片批号) REFERENCES 橡胶薄片(Id)
)
