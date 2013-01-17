CREATE TABLE [dbo].[Grade] (
    [Number] INT          NOT NULL IDENTITY,
    [Code]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [UX_Grade_Code] UNIQUE NONCLUSTERED ([Code] ASC)
);


