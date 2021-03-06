/****** Script for SelectTopNRows command from SSMS  ******/
SELECT     [2011Classes].DivisionNumber, [2011Classes].SchoolNumber, [2011Classes].GradeCode, [2011Classes].StudentCount, School.Id AS SchoolId, Grade.Number AS GradeNumber
FROM         [2011Classes] INNER JOIN
                      School ON [2011Classes].DivisionNumber = School.DivisionNumber AND [2011Classes].SchoolNumber = School.Number 
                      CROSS JOIN
                      Grade WHERE Grade.Code = [2011Classes].GradeCode