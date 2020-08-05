CREATE TABLE [dbo].[产品消耗]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [产品名称] NVARCHAR(50) NOT NULL, 
    [内层胶消耗量] FLOAT(2) NULL, 
    [外层胶消耗量] FLOAT(2) NULL, 
    [帘布消耗量] FLOAT(2) NULL, 
    [加入日期] DATETIME NULL
)
