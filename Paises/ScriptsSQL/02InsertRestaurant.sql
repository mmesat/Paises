use [Country]
go
SET IDENTITY_INSERT [dbo].[Restaurants]  ON
DECLARE @pais VARCHAR(50)
DECLARE @ID INT = 1

DECLARE cur CURSOR FOR
SELECT name FROM sys.databases WHERE name <> 'master' AND name <> 'tempdb'

OPEN cur

FETCH NEXT FROM cur INTO @pais

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO Restaurants(Id, Name) VALUES (@ID, @pais + ' Restaurant')
    SET @ID = @ID + 1
    FETCH NEXT FROM cur INTO @pais
END

CLOSE cur
DEALLOCATE cur
SET IDENTITY_INSERT [dbo].[Restaurants]  OFF