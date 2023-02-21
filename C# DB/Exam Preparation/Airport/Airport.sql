--CREATE DATABASE Airport
--GO

--USE Airport
--GO

----1. Database design

CREATE TABLE Passengers(
 Id INT PRIMARY KEY IDENTITY,
 FullName VARCHAR(100) UNIQUE NOT NULL,
 Email VARCHAR(50) UNIQUE NOT NULL
)

CREATE TABLE Pilots(
 Id INT PRIMARY KEY IDENTITY,
 FirstName VARCHAR(30) UNIQUE NOT NULL,
 LastName VARCHAR(30) UNIQUE NOT NULL,
 Age TinyInt CHECK(Age >= 21 AND AGE <= 62) NOT NULL,
 Rating FLOAT CHECK(Rating BETWEEN 0.0 AND 10.0) NOT NULL
)

CREATE TABLE AircraftTypes(
 Id INT PRIMARY KEY IDENTITY,
 TypeName VARCHAR(30) UNIQUE NOT NULL
)

CREATE TABLE Aircraft(
 Id INT PRIMARY KEY IDENTITY,
 Manufacturer VARCHAR(25) NOT NULL,
 Model VARCHAR(30) NOT NULL,
 [Year] INT NOT NULL,
 FlightHours INT,
 Condition CHAR NOT NULL,
 TypeId INT FOREIGN KEY REFERENCES AircraftTypes(Id) NOT NULL
)

CREATE TABLE PilotsAircraft(
 AircraftId INT FOREIGN KEY REFERENCES Aircraft(Id) NOT NULL,
 PilotId INT FOREIGN KEY REFERENCES Pilots(Id) NOT NULL,
 PRIMARY KEY(AircraftId, PilotId)
)

CREATE TABLE Airports(
 Id INT PRIMARY KEY IDENTITY,
 AirportName VARCHAR(70) UNIQUE NOT NULL,
 Country VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE FlightDestinations(
 Id INT PRIMARY KEY IDENTITY,
 AirportId INT FOREIGN KEY REFERENCES Airports(Id) NOT NULL,
 [Start] DateTime NOT NULL,
 AircraftId INT FOREIGN KEY REFERENCES Aircraft(Id) NOT NULL,
 PassegerId INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL,
 TicketPrice DECIMAL (18,2) DEFAULT 15 NOT NULL
)


----2. Insert

INSERT INTO Passengers(FullName, Email)
SELECT
CONCAT(FirstName, ' ', LastName),
CONCAT(FirstName, LastName, '@gmail.com')
FROM Pilots
WHERE Id BETWEEN 5 AND 15

----3. Update

UPDATE Aircraft
SET Condition = 'A'
WHERE Condition = 'C' OR CONDITION ='B' AND 
FlightHours IS NULL OR FlightHours <= 100 AND
Year >= 2013

----4. Delete
DELETE  FROM Passengers
WHERE LEN(FullName) <= 10

--5. Aircraft

SELECT Manufacturer,
       Model,
	   FlightHours,
	   Condition
FROM Aircraft
ORDER BY FlightHours DESC

--6. Pilots and Aircraft
SELECT p.FirstName,
       p.LastName,
	   a.Manufacturer,
	   a.Model,
	   a.FlightHours
FROM PilotsAircraft AS pa
JOIN Pilots AS p
ON pa.PilotId = p.Id
JOIN Aircraft AS a
ON pa.AircraftId = a.Id
WHERE a.FlightHours IS NOT NULL AND a.FlightHours < 304
ORDER BY a.FlightHours DESC, p.FirstName ASC

--7. Top 20 Flight Destinations
SELECT TOP(20)
       fd.Id,
       fd.Start,
	   pa.FullName,
	   a.AirportName,
	   fd.TicketPrice
FROM FlightDestinations as fd
JOIN Airports AS a
ON fd.AirportId = a.Id
JOIN Passengers as pa
ON fd.PassegerId = pa.Id
WHERE DATEPART(DAY, fd.Start) % 2 = 0
ORDER BY TicketPrice DESC, AirportName ASC

--8. Number of Flights for Each Aircraft
SELECT a.Id AS AircraftId,
       a.Manufacturer,
	   a.FlightHours,
	   COUNT(fd.Id)  AS FlightDestinationsCount,
	   ROUND(AVG(fd.TicketPrice), 2) AS AvgPrice
FROM FlightDestinations as fd
JOIN Aircraft AS a
ON fd.AircraftId = a.Id
GROUP BY a.Id, a.Manufacturer, a.FlightHours
HAVING COUNT(fd.Id) >= 2
ORDER BY 4 DESC, 1

--9. Regular Passengers
SELECT p.FullName,
       COUNT(a.Id) AS CountOfAircfrafts,
	   SUM(fd.TicketPrice) AS TotalPayed
FROM Passengers AS p
JOIN FlightDestinations AS fd
ON p.Id = fd.PassegerId
JOIN Aircraft AS a
ON fd.AircraftId = a.Id
WHERE SUBSTRING(p.FullName,2,1) = 'a'
GROUP BY p.Id,p.FullName
HAVING COUNT(a.Id) > 1
ORDER BY p.FullName

10. Full Info for Flight Destinations
SELECT ap.AirportName,
        fd.Start AS DayTime,
		fd.TicketPrice,
		p.FullName,
		a.Manufacturer,
		a.Model
FROM FlightDestinations as fd
JOIN Aircraft AS a
ON fd.AircraftId = a.Id
JOIN Airports AS ap
ON fd.AirportId = ap.Id
JOIN Passengers AS p
ON fd.PassegerId = p.Id
WHERE fd.TicketPrice > 2500 AND
CAST(fd.Start AS TIME) BETWEEN '6:20' AND '20:00'
ORDER BY a.Model ASC

--11. Find all Destinations by Email Address
CREATE FUNCTION udf_FlightDestinationsByEmail(@email varchar(50))
RETURNS INT
AS 
BEGIN
  DECLARE @destinationsCount INT = (
   SELECT
    COUNT(fd.Id)
	FROM Passengers AS p
	JOIN FlightDestinations AS fd
	ON p.Id = fd.PassegerId
	WHERE p.Email = @email
	GROUP BY p.Id
  )

  RETURN @destinationsCount
END

GO

SELECT dbo.udf_FlightDestinationsByEmail('PierretteDunmuir@gmail.com')
SELECT dbo.udf_FlightDestinationsByEmail('Montacute@gmail.com')


--12. Full Info for Airports
CREATE PROCEDURE usp_SearchByAirportName @airportName VARCHAR(70)
AS
BEGIN
 SELECT a.AirportName,
        p.FullName,
		CASE WHEN fd.TicketPrice <= 400 THEN 'Low' 
		WHEN fd.TicketPrice BETWEEN 401 AND 1500 THEN 'Medium'
		ELSE 'Hight' END AS LevelOfTicketPrice,
		ac.Manufacturer,
		ac.Condition,
		t.TypeName
FROM Airports AS a
JOIN FlightDestinations AS fd ON a.Id = fd.AirportId
JOIN Passengers AS p ON fd.PassegerId = p.Id
JOIN Aircraft AS ac ON fd.AirportId = p.Id
JOIN AircraftTypes AS t ON ac.TypeId = t.Id
WHERE a.AirportName = @airportName
ORDER BY ac.Manufacturer , p.FullName
END

EXEC usp_SearchByAirportName 'Sir Seretse Khama International Airport'



















