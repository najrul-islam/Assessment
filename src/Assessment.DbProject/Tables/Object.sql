CREATE TABLE [dbo].[Object] (
    [Id]   TINYINT       IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Object] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO

