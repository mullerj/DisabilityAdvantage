CREATE TABLE [dbo].[State] (
    [Number]       INT           NOT NULL IDENTITY,
    [Name]         VARCHAR (100) NOT NULL,
    [Abbreviation] VARCHAR (2)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Number] ASC),
    CONSTRAINT [UX_State_Abbreviation] UNIQUE NONCLUSTERED ([Abbreviation] ASC),
    CONSTRAINT [UX_State_Name] UNIQUE NONCLUSTERED ([Name] ASC)
);


