CREATE TABLE [dbo].[Astronautit] (
    [Etunimi]                   VARCHAR (50) NOT NULL,
    [Sukunimi]                  VARCHAR (50) NOT NULL,
    [Syntymäaika]               DATE         NOT NULL,
    [Sukupuoli]                 INT     NOT NULL,
    [Kansallisuus]              INT NOT NULL,
    [Avaruudessa vietetty aika] INT          NULL,
    PRIMARY KEY CLUSTERED ([Etunimi] ASC), 
    CONSTRAINT [FK_Astronautit_ToTable] FOREIGN KEY ([Kansallisuus]) REFERENCES [Kansallisuus]([Id]), 
    CONSTRAINT [FK_Astronautit_ToTable_1] FOREIGN KEY ([Sukupuoli]) REFERENCES [Sukupuoli]([Id])
);

