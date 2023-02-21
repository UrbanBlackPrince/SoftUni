--CREATE DATABASE [CigarShop]
--GO

--USE [CigarShop]
--GO

--01. Database Design
CREATE TABLE Sizes
(
	Id INT IDENTITY PRIMARY KEY,
	[Length] INT CHECK([Length] BETWEEN 10 AND 25) NOT NULL,
	RingRange DECIMAL(2,1) CHECK(RingRange BETWEEN 1.5 AND 7.5) NOT NULL
)

CREATE TABLE Tastes
(
	Id INT IDENTITY PRIMARY KEY,
	TasteType VARCHAR(20) NOT NULL,
	TasteStrength VARCHAR(15) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
)

CREATE TABLE Brands
(
	Id INT IDENTITY PRIMARY KEY,
	BrandName VARCHAR(30) UNIQUE NOT NULL,
	BrandDescription VARCHAR(MAX)
)

CREATE TABLE Cigars
(
	Id INT IDENTITY PRIMARY KEY,
	CigarName VARCHAR(80) NOT NULL,
	BrandId INT REFERENCES Brands(Id) NOT NULL,
	TastId INT REFERENCES Tastes(Id) NOT NULL,
	SizeId INT REFERENCES Sizes(Id) NOT NULL,
	PriceForSingleCigar MONEY NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
)

CREATE TABLE Addresses
(
	Id INT IDENTITY PRIMARY KEY,
	Town VARCHAR(30) NOT NULL,
	Country NVARCHAR(30) NOT NULL,
	Streat NVARCHAR(100) NOT NULL,
	ZIP VARCHAR(20) NOT NULL
)

CREATE TABLE Clients
(
	Id INT IDENTITY PRIMARY KEY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	AddressId INT REFERENCES Addresses(Id) NOT NULL
)

CREATE TABLE ClientsCigars
(
	ClientId INT REFERENCES Clients(Id) NOT NULL,
	CigarId INT REFERENCES Cigars(Id) NOT NULL,
	PRIMARY KEY(ClientId, CigarId)
)

--02. Insert
INSERT INTO Cigars (CigarName, BrandId, TastId, SizeId, PriceForSingleCigar, ImageURL) VALUES
	('COHIBA ROBUSTO', 9, 1, 5, 15.50, 'cohiba-robusto-stick_18.jpg'),
	('COHIBA SIGLO I', 9, 1, 10, 410.00, 'cohiba-siglo-i-stick_12.jpg'),
	('HOYO DE MONTERREY LE HOYO DU MAIRE', 14, 5, 11, 7.50, 'hoyo-du-maire-stick_17.jpg'),
	('HOYO DE MONTERREY LE HOYO DE SAN JUAN', 14, 4, 15 , 32.00, 'hoyo-de-san-juan-stick_20.jpg'),
	('TRINIDAD COLONIALES', 2, 3, 8, 85.21, 'trinidad-coloniales-stick_30.jpg')

INSERT INTO Addresses (Town, Country, Streat, ZIP) VALUES
	('Sofia', 'Bulgaria', '18 Bul. Vasil levski', 1000),
	('Athens', 'Greece', '4342 McDonald Avenue', 10435),
	('Zagreb', 'Croatia', '4333 Lauren Drive', 10000)

--03. Update
SELECT * FROM Cigars


UPDATE Cigars
	SET PriceForSingleCigar += PriceForSingleCigar * 0.2
	FROM Cigars AS c
	JOIN Tastes AS t ON t.Id = c.TastId
	WHERE t.TasteType = 'Spicy'

UPDATE Brands
	SET BrandDescription = 'New description'
	WHERE BrandDescription IS NULL


--04. Delete
DELETE FROM Clients
	WHERE AddressId IN (SELECT Id FROM Addresses WHERE SUBSTRING(Country, 1, 1) = 'C')

DELETE FROM Addresses
	WHERE SUBSTRING(Country, 1, 1) = 'C'

--05. Cigars By Price
SELECT CigarName, PriceForSingleCigar, ImageURL
FROM Cigars
ORDER BY PriceForSingleCigar ASC, CigarName DESC

--06. Cigars By Taste
SELECT c.Id, c.CigarName,c.PriceForSingleCigar,t.TasteType, t.TasteStrength
FROM Cigars AS c
INNER JOIN Tastes as t
On c.TastId = t.Id
WHERE t.TasteType = 'Earthy' OR t.TasteType = 'Woody'
ORDER BY c.PriceForSingleCigar DESC

--07. Clients Without Cigars
SELECT 
	Id,
	CONCAT_WS(' ', FirstName, LastName) AS ClientName,
	Email
	FROM Clients
	WHERE Id NOT IN (SELECT ClientId FROM ClientsCigars)
	ORDER BY ClientName

--08. First 5 Cigars
	 SELECT TOP(5)
   c.CigarName,
   c.PriceForSingleCigar,
   c.ImageURL
     FROM Cigars AS c
     JOIN Sizes AS s
     ON  s.Id = c.SizeId 
     WHERE s.[Length] >= 12 AND (c.CigarName LIKE '%ci%'
     OR c.PriceForSingleCigar > 50) AND s.RingRange > 2.55
     ORDER BY c.CigarName, c.PriceForSingleCigar DESC

--09. Clients With ZIP Codes
SELECT 
	CONCAT_WS(' ', c.FirstName, c.LastName) AS FullName,
	a.Country,
	a.ZIP, 
	CONCAT('$', MAX(PriceForSingleCigar)) AS CigarPrice
		FROM Clients AS c
		JOIN Addresses AS a ON a.Id = c.AddressId
		JOIN ClientsCigars AS cc ON cc.ClientId = c.Id
		JOIN Cigars AS cig ON cig.Id = cc.CigarId
		WHERE ISNUMERIC(a.ZIP) = 1
		GROUP BY c.Id, c.FirstName, c.LastName, a.Country, a.ZIP
		ORDER BY FullName

--10. Cigars By Size

SELECT 
	c.LastName,
	AVG(s.[Length]) AS CiagrLength,
	CEILING(AVG(s.RingRange)) AS CiagrRingRange
		FROM Clients AS c			
		JOIN ClientsCigars AS cc ON cc.ClientId = c.Id
		JOIN Cigars AS cg ON cg.Id = cc.CigarId
		JOIN Sizes AS s ON s.Id = cg.SizeId
		WHERE c.Id IN (SELECT DISTINCT [ClientId] FROM ClientsCigars)	
		GROUP BY  c.LastName
		ORDER BY AVG(s.[Length]) DESC

--11. Client with Cigars
CREATE FUNCTION udf_ClientWithCigars(@name NVARCHAR(30)) 
RETURNS INT
AS
BEGIN
DECLARE @userId INT = (
    SELECT [Id] 
	FROM [Clients]
	WHERE [FirstName] = @name
	)

DECLARE @numCigars INT = (
	SELECT COUNT (*) FROM [ClientsCigars]
	 WHERE [ClientId] = @userId
	)

	RETURN @numCigars
	END
GO

SELECT dbo.udf_ClientWithCigars('Joan')

--12. Search For Cigars
CREATE PROC usp_SearchByTaste @taste VARCHAR(20)
AS
BEGIN

SELECT a.CigarName,
       CONCAT('$', a.PriceForSingleCigar) AS Price,
	   d.TasteType,
	   b.BrandName,
	   CONCAT(c.[Length], 'cm') AS CigarLength,
	   CONCAT(c.RingRange, 'cm' ) AS CigarRingRange
FROM Cigars AS a
JOIN Brands AS b
ON a.BrandId = b.Id
JOIN Sizes AS c
ON a.SizeId = c.Id
JOIN Tastes as d
ON a.TastId = d.Id
WHERE d.TasteType = @taste
ORDER BY c.[Length] ASC, c.RingRange DESC
END

GO

EXEC usp_SearchByTaste 'Woody'