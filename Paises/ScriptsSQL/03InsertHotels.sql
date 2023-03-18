/****** Script for SelectTopNRows command from SSMS  ******/
use [Country]
go
SET IDENTITY_INSERT [dbo].[Hotels]  ON
DECLARE @hotel VARCHAR(50)
DECLARE @ID INT = 1

DECLARE cur CURSOR FOR
SELECT name FROM sys.databases WHERE name <> 'master' AND name <> 'tempdb'

OPEN cur

FETCH NEXT FROM cur INTO @hotel

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO Hotels(Id, Name) VALUES (@ID, @hotel + ' Hotel')
    SET @ID = @ID + 1
    FETCH NEXT FROM cur INTO @hotel
END

CLOSE cur
DEALLOCATE cur
SET IDENTITY_INSERT [dbo].[Hotels]  OFF