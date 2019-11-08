CREATE TABLE [dbo].[DropTables]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
	[CreepId] INT NOT NULL,
    [Chance] FLOAT NOT NULL,
    CONSTRAINT [PK_DropTables] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DropTable_Creep] FOREIGN KEY ([CreepId]) REFERENCES [Creeps]([Id])
)
