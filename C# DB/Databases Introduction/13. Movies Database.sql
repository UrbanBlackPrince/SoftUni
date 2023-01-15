CREATE DATABASE Movies

CREATE TABLE Directors
(
	Id INT IDENTITY PRIMARY KEY,
	DirectorName NVARCHAR(MAX) NOT NULL,
	Notes NVARCHAR(MAX),
)
CREATE TABLE Genres
(
	Id INT IDENTITY PRIMARY KEY,
	GenreName NVARCHAR(MAX) NOT NULL,
	Notes NVARCHAR(MAX),
)
CREATE TABLE Categories
(
    Id INT IDENTITY PRIMARY KEY,
	CategoryName NVARCHAR(MAX) NOT NULL,
	Notes NVARCHAR(MAX),
)
CREATE TABLE Movies
(
	Id INT IDENTITY PRIMARY KEY,
	Title NVARCHAR(100) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
	CopyrightYear INT NOT NULL,
	[Length] TIME,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Rating DECIMAL(4,2),
	Notes NVARCHAR(MAX)
)
INSERT INTO Directors VALUES
('Gabriel', NULL),
('Ivan', NULL),
('Gogi', NULL),
('Radina', NULL),
('Lili', NULL)
INSERT INTO Genres VALUES
('Military', NULL),
('Romance', NULL),
('Comedy', NULL),
('Drama', NULL),
('Russian', NULL)
INSERT INTO Categories VALUES
('Russian', NULL),
('Comedy', NULL),
('Military', NULL),
('Drama', NULL),
('Romance', NULL)
INSERT INTO Movies VALUES
('Enemy at gates', 1, 1998, NULL, 4, 4, 10.0, NULL),
('Two man and half', 2, 1999, NULL, 1, 1, 5.5, NULL),
('Sex Life', 3, 2021, NULL, 3, 3, 9.5, NULL),
('Djumanji', 4, 2020, NULL, 2, 2, 6.6, NULL),
('Scream', 5, 2020, NULL, 5, 5, 3.0, NULL)