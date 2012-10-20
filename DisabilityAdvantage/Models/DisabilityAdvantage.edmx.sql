
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/20/2012 05:52:31
-- Generated from EDMX file: C:\Projects\DisabilityAdvantage\DisabilityAdvantage\Models\DisabilityAdvantage.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DisabilityAdvantage];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ChildCounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChildCounts];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ChildCounts'
CREATE TABLE [dbo].[ChildCounts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SCHOOL_YR] nvarchar(max)  NOT NULL,
    [LEVEL_CODE] nvarchar(max)  NOT NULL,
    [DIV_NUM] nvarchar(max)  NOT NULL,
    [DIV_NAME] nvarchar(max)  NOT NULL,
    [SCH_NUM] nvarchar(max)  NOT NULL,
    [SCH_NAME] nvarchar(max)  NOT NULL,
    [GRADE_CODE] nvarchar(max)  NOT NULL,
    [FEDERAL_RACE_CODE] nvarchar(max)  NOT NULL,
    [GENDER] nvarchar(max)  NOT NULL,
    [DISABILITY_FLAG] nvarchar(max)  NOT NULL,
    [LEP_FLAG] nvarchar(max)  NOT NULL,
    [DISADVANTAGED_FLAG] nvarchar(max)  NOT NULL,
    [PRIMARY_DISABILITY_TYPE] nvarchar(max)  NOT NULL,
    [DEC1_CNT] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ChildCounts'
ALTER TABLE [dbo].[ChildCounts]
ADD CONSTRAINT [PK_ChildCounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------