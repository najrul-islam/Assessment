CREATE TABLE [dbo].[Building] (
    [Id]       SMALLINT      IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NULL,
    [Location] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Building] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO

