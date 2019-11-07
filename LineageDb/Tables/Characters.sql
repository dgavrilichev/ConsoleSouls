CREATE TABLE [dbo].[Characters]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Experience] INT NOT NULL, 
    [Level] INT NOT NULL,
	[CreateDate] DATETIME2 NOT NULL,
	CONSTRAINT [PK_Characters] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [AK_Name] UNIQUE(Name)  

)
