CREATE TABLE [dbo].[Nimi] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [nimet] VARCHAR (50) NULL,
    [opintoryhma_Id] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Nimi_Ryhma] FOREIGN KEY ([opintoryhma_Id]) REFERENCES [opiskelijaryhma]([id])
);

