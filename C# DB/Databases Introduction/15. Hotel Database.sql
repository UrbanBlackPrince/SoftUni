CREATE TABLE Employees
(
 Id INT IDENTITY PRIMARY KEY,
 FirstName NVARCHAR(MAX) NOT NULL,
 LastName NVARCHAR(MAX) NOT NULL,
 Title NVARCHAR(MAX),
 Notes NVARCHAR(MAX)
)

CREATE TABLE Customers
(
 AccountNumber INT PRIMARY KEY,
 FirstName NVARCHAR(MAX) NOT NULL,
 LastName NVARCHAR(30) NOT NULL,
 PhoneNumber NVARCHAR(20) NOT NULL,
 EmergencyName NVARCHAR(MAX),
 EmergencyNumber NVARCHAR(MAX),
 Notes NVARCHAR(MAX)
)

CREATE TABLE RoomStatus
(
	RoomStatus NVARCHAR(30) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)

CREATE TABLE RoomTypes
(
	RoomType NVARCHAR(30) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)
CREATE TABLE BedTypes
(
	BedType NVARCHAR(30) PRIMARY KEY,
	Notes NVARCHAR(MAX)
)
CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY,
	RoomType NVARCHAR(30) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType NVARCHAR(30) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate DECIMAL(5,2),
	RoomStatus NVARCHAR(30) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
	Notes NVARCHAR(MAX)
)
CREATE TABLE Payments
(
	Id INT IDENTITY PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	PaymentDate DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	FirstDateOccupied DATETIME2,
	LastDateOccupied DATETIME2,
	TotalDays INT,
	AmountCharged DECIMAL(6,2) NOT NULL,
	TaxRate DECIMAL(2,1),
	TaxAmount DECIMAL(6,2),
	PaymentTotal DECIMAL(6,2),
	Notes NVARCHAR(MAX)
)
CREATE TABLE Occupancies
(
	Id INT IDENTITY PRIMARY KEY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATE,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber),
	RateApplied DECIMAL(2,1),
	PhoneCharge BIT,
	Notes NVARCHAR(MAX),
)

INSERT INTO Employees VALUES
('Gabriel', 'Nikolov', NULL, NULL),
('Zhivko', 'Pavlov', NULL, NULL),
('Ivan', 'Petrov', NULL, NULL)
INSERT INTO Customers VALUES
(4398478, 'Gosho', 'Petrov', '+359 88 807 1598', NULL, NULL, NULL),
(3816351, 'Pepi', 'Dinev', '+359 89 456 1234', NULL, NULL, NULL),
(9897876, 'Meto', 'Ilienski', '+359 88 324 1234', NULL, NULL, NULL)
INSERT INTO RoomStatus VALUES
('FREE', NULL),
('OCCUPIED', NULL),
('ONHOLD', NULL)
INSERT INTO RoomTypes VALUES
('Single', NULL),
('Double', NULL),
('Triple', NULL)
INSERT INTO BedTypes VALUES
('Double bed', NULL),
('Queen bed', NULL),
('King bed', NULL)
INSERT INTO Rooms VALUES
(123, 'Single', 'King bed', NULL, 'FREE', NULL),
(333, 'Triple', 'Queen bed', NULL, 'ONHOLD', NULL),
(421, 'Double', 'Double bed', NULL, 'OCCUPIED', NULL)
INSERT INTO Payments(EmployeeId,PaymentDate,AccountNumber,AmountCharged) VALUES
(2, '2022-08-02', 9661102, 233.8),
(3, '2020-10-22', 5647568, 267.8),
(1, '2021-01-07', 1236590, 33.67)
INSERT INTO Occupancies(EmployeeId,AccountNumber,RoomNumber) VALUES
(3, 1236590, 333),
(1, 9661102, 421),
(2, 5647568, 123)