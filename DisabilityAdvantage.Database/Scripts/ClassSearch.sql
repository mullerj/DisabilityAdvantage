/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [SCHOOL_YEAR]
      ,[LEVEL_CODE]
      ,[DIV_NUM]
      ,[DIV_NAME]
      ,[SCH_NUM]
      ,[SCH_NAME]
      ,[GRADE_CODE]
      ,[FEDERAL_RACE_CODE]
      ,[GENDER]
      ,[DISABILITY_FLAG]
      ,[LEP_FLAG]
      ,[DISADVANTAGED_FLAG]
      ,[FALL_MEMBERSHIP_CNT]
  FROM [DisabilityAdvantage].[dbo].[2011_fall_membership]
  WHERE LEVEL_CODE = '"SCH"' AND GRADE_CODE != '' AND FEDERAL_RACE_CODE = '' AND Gender = '' AND DISABILITY_FLAG = '' AND LEP_FLAG = '' AND DISADVANTAGED_FLAG = ''