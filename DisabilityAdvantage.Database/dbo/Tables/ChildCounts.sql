CREATE TABLE [dbo].[ChildCounts] (
    [Id]                      INT            IDENTITY (1, 1) NOT NULL,
    [SCHOOL_YR]               NVARCHAR (MAX) NOT NULL,
    [LEVEL_CODE]              NVARCHAR (MAX) NOT NULL,
    [DIV_NUM]                 NVARCHAR (MAX) NOT NULL,
    [DIV_NAME]                NVARCHAR (MAX) NOT NULL,
    [SCH_NUM]                 NVARCHAR (MAX) NOT NULL,
    [SCH_NAME]                NVARCHAR (MAX) NOT NULL,
    [GRADE_CODE]              NVARCHAR (MAX) NOT NULL,
    [FEDERAL_RACE_CODE]       NVARCHAR (MAX) NOT NULL,
    [GENDER]                  NVARCHAR (MAX) NOT NULL,
    [DISABILITY_FLAG]         NVARCHAR (MAX) NOT NULL,
    [LEP_FLAG]                NVARCHAR (MAX) NOT NULL,
    [DISADVANTAGED_FLAG]      NVARCHAR (MAX) NOT NULL,
    [PRIMARY_DISABILITY_TYPE] NVARCHAR (MAX) NOT NULL,
    [DEC1_CNT]                INT            NOT NULL,
    CONSTRAINT [PK_ChildCounts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

