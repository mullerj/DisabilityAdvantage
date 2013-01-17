CREATE TABLE [dbo].[Division] (
    [Number] INT          NOT NULL IDENTITY,
    [Name]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [UX_Division_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);


