use [Country]
go
DECLARE @IdCountry INT = 1
DECLARE @IdRestaurant INT = 1

WHILE @IdCountry <= 230
BEGIN
    WHILE @IdRestaurant <= 5
    BEGIN
        INSERT INTO countryRestaurants (IdCountry, IdRestaurant) VALUES (@IdCountry, @IdRestaurant)
        SET @IdRestaurant = @IdRestaurant + 1
    END
    SET @IdRestaurant = 1
    SET @IdCountry = @IdCountry + 1
END
