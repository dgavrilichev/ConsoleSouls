CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [ItemType] INT NOT NULL, 
    [Price] INT NOT NULL, 
    [Bodypart] INT NOT NULL, --1 weapon, 2 armor, 3 etcItem
)
