CREATE TABLE [dbo].[Table] (
    [pelaaja_id]  INT          IDENTITY (1, 1) NOT NULL,
    [nimi]        VARCHAR (50) NULL,
    [sukupuoli]   VARCHAR (50) NULL,
    [lähiosoite]  VARCHAR (50) NULL,
    [postinumero] INT          NULL,
    [puhelin]     INT          NULL,
    [email]       VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([pelaaja_id] ASC)
);

