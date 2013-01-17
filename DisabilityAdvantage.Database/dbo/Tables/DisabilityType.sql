CREATE TABLE [dbo].[DisabilityType] (
    [Number] INT          NOT NULL IDENTITY,
    [Code]   VARCHAR (2)  NOT NULL,
    [Name]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [UX_DisabilityType_Code] UNIQUE NONCLUSTERED ([Code] ASC),
    CONSTRAINT [UX_DisabilityType_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);


