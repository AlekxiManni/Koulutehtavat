CREATE TABLE [dbo].[julkaisijat] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [julkaisijan_nimi] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_julkaisijat_ToTable] FOREIGN KEY ([julkaisijan_nimi]) REFERENCES [elokuvat]([])
);

