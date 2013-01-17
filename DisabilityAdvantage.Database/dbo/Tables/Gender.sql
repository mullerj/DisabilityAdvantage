CREATE TABLE [dbo].[Gender] (
    [Number] INT          NOT NULL IDENTITY,
    [Code]   CHAR (1)     NOT NULL,
    [Name]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [IX_Gender_Code] UNIQUE NONCLUSTERED ([Code] ASC),
    CONSTRAINT [IX_Gender_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);


