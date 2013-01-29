CREATE TABLE [dbo].[School] (
    [Id]         INT          NOT NULL IDENTITY,
	[Number]         INT          NOT NULL,
    [Name]           VARCHAR (80) NOT NULL,
    [DivisionNumber] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_School_Division] FOREIGN KEY ([DivisionNumber]) REFERENCES [dbo].[Division] ([Number])
);


