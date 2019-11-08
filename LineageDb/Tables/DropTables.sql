CREATE TABLE [dbo].[DropTables]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[CreepId] INT NOT NULL,
    [Chance] FLOAT NOT NULL,
    CONSTRAINT [PK_DropTables] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DropTable_Creep] FOREIGN KEY ([CreepId]) REFERENCES [Creeps]([Id])
)
