/****** Script for SelectTopNRows command from SSMS  ******/
SELECT     DisabilityImport.Id, DisabilityImport.AcademicYearNumber, DisabilityImport.DivisionNumber, DisabilityImport.SchoolNumber, DisabilityImport.GradeCode, DisabilityImport.DisabilityTypeCode, 
                      DisabilityImport.StudentCount, Class.Number AS ClassNumber, DisabilityType.Number AS DisabilityNumber
FROM         School INNER JOIN
                      Class ON School.Id = Class.SchoolId INNER JOIN
                      Grade ON Class.GradeNumber = Grade.Number INNER JOIN
                      DisabilityImport ON School.Number = DisabilityImport.SchoolNumber AND School.DivisionNumber = DisabilityImport.DivisionNumber AND Grade.Code = DisabilityImport.GradeCode INNER JOIN
                      DisabilityType ON DisabilityImport.DisabilityTypeCode = DisabilityType.Code