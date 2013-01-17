CREATE TABLE [dbo].[Race] (
    [Number] INT         NOT NULL IDENTITY,
    [Code]   VARCHAR (2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [UX_Race_Code] UNIQUE NONCLUSTERED ([Code] ASC)
);


