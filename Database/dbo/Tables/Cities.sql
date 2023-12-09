CREATE TABLE [dbo].[Cities] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [City] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED ([id] ASC)
);

