/****** Script for SelectTopNRows command from SSMS  ******/
SELECT     ClassImport.Id, ClassImport.DivisionNumber, ClassImport.SchoolNumber, ClassImport.GradeNumber, ClassImport.StudentCount, School.Id AS SchoolId
FROM         ClassImport INNER JOIN
                      School ON ClassImport.SchoolNumber = School.Number AND ClassImport.DivisionNumber = School.DivisionNumber