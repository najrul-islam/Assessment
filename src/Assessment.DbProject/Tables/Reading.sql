CREATE TABLE [dbo].[Reading] (
    [Id]          BIGINT          IDENTITY (1, 1) NOT NULL,
    [BuildingId]  SMALLINT        NOT NULL,
    [ObjectId]    TINYINT         NOT NULL,
    [DataFieldId] TINYINT         NOT NULL,
    [Value]       DECIMAL (18, 2) NOT NULL,
    [Timestamp]   DATETIME        NOT NULL,
    CONSTRAINT [PK_Reading] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO

