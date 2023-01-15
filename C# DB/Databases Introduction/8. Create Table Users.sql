CREATE TABLE Users
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Username VARCHAR(30) NOT NULL,
 [Password] VARCHAR(26) NOT NULL,
 ProfilePicture VARBINARY (MAX),
 LastLoginTime TIME,
 IsDeleted BIT,
)

INSERT INTO Users VALUES
('Gabriel', 'UBP', NULL, NULL, 0),
('Ivan','Krastnica', NULL, NULL, 1),
('Gogi','Manqka', NULL, NULL, 1),
('Pesho', 'Piqnka', NULL, NULL, 0),
('Nikolay', 'Banker', NULL, NULL, 0)