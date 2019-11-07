CREATE TABLE [dbo].[Creeps]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Behaviour] INT NOT NULL, --1 = passive, 2 = aggressive
	[Experience] INT NOT NULL, 
    [Hp] INT NOT NULL, 

)
