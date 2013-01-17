CREATE TABLE [dbo].[School] (
    [Number]         INT          NOT NULL IDENTITY,
    [Name]           VARCHAR (80) NOT NULL,
    [DivisionNumber] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [FK_School_Division] FOREIGN KEY ([DivisionNumber]) REFERENCES [dbo].[Division] ([Number]),
    CONSTRAINT [UX_School_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);


