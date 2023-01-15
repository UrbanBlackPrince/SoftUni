CREATE TABLE People
(
Id INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(100) NOT NULL,
Picture VARBINARY(MAX),
Height DECIMAL(3,2),
[Weight] DECIMAL (5,2),
Gender CHAR(1) NOT NULL,
Birthdate DATETIME2 NOT NULL,
Biography NVARCHAR(MAX)
)

INSERT INTO PEOPLE VALUES
('Gogi', NULL, 1.32, 12, 'm', '2000-12-06', 'manqk'),
('Ivan', NULL, 1.54, 43, 'm', '1999-04-27', 'Batka'),
('Zhivko', NULL, 2.01, 56, 'm', '1900-05-10', 'Narkoman'),
('Bobi', NULL, 1.98, 87, 'm', '1999-05-25', 'Boksior'),
('Radina', NULL, 1.60, 45, 'f', '2000-07-22', 'Slav Barbie')