CREATE TABLE [dbo].[AcademicYear] (
    [Number] INT         NOT NULL IDENTITY,
    [Name]   VARCHAR (9) NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [UX_AcademicYear_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);


