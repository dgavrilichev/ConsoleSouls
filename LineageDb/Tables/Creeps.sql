CREATE TABLE [dbo].[Creeps]
(
	[Id] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Behaviour] INT NOT NULL, --1 = passive, 2 = aggressive
	[Experience] INT NOT NULL, 
    [Hp] INT NOT NULL, 
    [Str] INT NOT NULL, 
	[Dex] INT NOT NULL, 
	[Con] INT NOT NULL, 
	[Int] INT NOT NULL, 
	[Wit] INT NOT NULL, 
	[Men] INT NOT NULL, 
    [Pattack] FLOAT NOT NULL, 
    [Mattack] FLOAT NOT NULL, 
    [Pdef] FLOAT NOT NULL, 
    [Mdef] FLOAT NOT NULL, 
    [BonusAccuracy] FLOAT NOT NULL, 
    [AttackSpeed] INT NOT NULL, 
    [Range] INT NOT NULL, 
	CONSTRAINT [PK_Creeps] PRIMARY KEY CLUSTERED ([Id] ASC)
)
