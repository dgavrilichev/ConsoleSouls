CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [ItemType] INT NOT NULL, 
    [Data] NVARCHAR(MAX) NOT NULL, --1 weapon, 2 armor, 3 etcItem
	CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([Id] ASC)
)
