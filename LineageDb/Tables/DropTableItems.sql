CREATE TABLE [dbo].[DropTableItems]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [DropTableId] INT NOT NULL,
	[ItemId] INT NOT NULL,
	[Chance] FLOAT NOT NULL, 
    CONSTRAINT [PK_DropTableItems] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_DropTableItems_DropTable] FOREIGN KEY ([DropTableId]) REFERENCES [DropTables]([Id]),
	CONSTRAINT [FK_DropTableItems_Item] FOREIGN KEY ([ItemId]) REFERENCES [Items]([Id])
)
