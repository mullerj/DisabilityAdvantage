CREATE TABLE [dbo].[Class]
(
	[Number] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SchoolNumber] INT NOT NULL, 
    [GradeNumber] INT NOT NULL, 
    [AcademicYearNumber] INT NOT NULL, 
    [StudentCount] INT NOT NULL, 
    CONSTRAINT [FK_Class_School] FOREIGN KEY ([SchoolNumber]) REFERENCES [School]([Number]), 
    CONSTRAINT [FK_Class_GradeNumber] FOREIGN KEY ([GradeNumber]) REFERENCES [Grade]([Number]), 
    CONSTRAINT [FK_Class_AcademicYear] FOREIGN KEY ([AcademicYearNumber]) REFERENCES [AcademicYear]([Number])
)
