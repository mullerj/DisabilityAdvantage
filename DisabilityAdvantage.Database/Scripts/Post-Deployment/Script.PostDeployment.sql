/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
/*
:r .\ChildCounts_Insert.sql 
*/	
:r .\AcademicYear_Insert.sql
:r .\DisabilityType_Insert.sql
:r .\Division_Insert.sql
:r .\School_Insert.sql
:r .\Grade_Insert.sql
:r .\Class_Insert.sql
:r .\Disability_Insert.sql