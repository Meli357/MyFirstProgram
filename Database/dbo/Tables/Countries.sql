CREATE TABLE [dbo].[Countries] (
    [id]      INT           IDENTITY (1, 1) NOT NULL,
    [Country] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([id] ASC)
);

