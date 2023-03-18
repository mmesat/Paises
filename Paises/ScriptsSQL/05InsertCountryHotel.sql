use [Country]
go
DECLARE @IdCountry INT = 1
DECLARE @IdHotel INT = 1

WHILE @IdCountry <= 230
BEGIN
    WHILE @IdHotel <= 5
    BEGIN
        INSERT INTO CountryHotel(IdCountry, IdHotel) VALUES (@IdCountry, @IdHotel)
        SET @IdHotel = @IdHotel + 1
    END
    SET @IdHotel = 1
    SET @IdCountry = @IdCountry + 1
END