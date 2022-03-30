CREATE TABLE [dbo].[CDInventory] (
    [InvNumber] INT           NOT NULL,
    [Title]     NVARCHAR (50) NOT NULL,
    [Artist]    NVARCHAR (50) NOT NULL,
    [Price]     REAL          NOT NULL,
    [Quantity]  INT           NOT NULL,
    [GenreId]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([InvNumber] ASC), 
    CONSTRAINT [FK_CDInventory_ToGenre] FOREIGN KEY (GenreID) REFERENCES Genre(GenreID)
);

