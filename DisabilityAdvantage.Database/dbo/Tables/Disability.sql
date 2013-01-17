CREATE TABLE [dbo].[Disability]
(
	[Number] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ClassNumber] INT NOT NULL, 
    [DisabilityTypeNumber] INT NOT NULL, 
    [StudentCount] INT NOT NULL, 
    CONSTRAINT [FK_Disability_Class] FOREIGN KEY ([ClassNumber]) REFERENCES [Class]([Number]), 
    CONSTRAINT [FK_Disability_DisabilityType] FOREIGN KEY ([DisabilityTypeNumber]) REFERENCES [DisabilityType]([Number])
)
