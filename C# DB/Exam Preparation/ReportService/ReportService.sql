CREATE DATABASE ReportService
GO

USE ReportService
GO
--01. DDL 
CREATE TABLE Users(
 Id INT PRIMARY KEY IDENTITY,
 Username VARCHAR(30) UNIQUE NOT NULL,
 Password VARCHAR(50) NOT NULL,
 Name VARCHAR(50),
 Birthdate DATETIME,
 Age INT CHECK(Age >= 14 AND Age <=110),
 Email VARCHAR(50) NOT NULL
)

CREATE TABLE Departments(
 Id INT PRIMARY KEY IDENTITY,
 Name VARCHAR(50) NOT NULL
)

CREATE TABLE Employees(
 Id INT PRIMARY KEY IDENTITY,
 FirstName VARCHAR(25),
 LastName VARCHAR(25),
 Birthdate DATETIME,
 Age INT CHECK (Age >= 18 AND Age <= 110),
 DepartmentId INT FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE Categories(
 Id INT PRIMARY KEY IDENTITY,
 Name VARCHAR(50) NOT NULL,
 DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL
)

CREATE TABLE Status(
 Id INT PRIMARY KEY IDENTITY,
 Label VARCHAR(20) NOT NULL,
)

CREATE TABLE Reports(
 Id INT PRIMARY KEY IDENTITY,
 CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
 StatusId INT FOREIGN KEY REFERENCES Status(Id) NOT NULL,
 OpenDate DATETIME NOT NULL,
 CloseDate DATETIME,
 Description VARCHAR(200) NOT NULL,
 UserId INT FOREIGN KEY REFERENCES Users(Id) NOT NULL,
 EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) 
)

--02. Insert 
INSERT INTO Employees(FirstName,LastName,Birthdate,DepartmentId)
VALUES
('Marlo', 'O''Malley', '1958-9-21', 1 ),
('Niki', 'Stanaghan', '1969-11-26', 4 ),
('Ayrton', 'Senna', '1960-03-21', 9),
('Ronnie', 'Peterson', '1944-02-14', 9 ),
('Giovanna', 'Amati', '1959-07-20', 5 )

INSERT INTO Reports(CategoryId, StatusId, OpenDate, CloseDate, Description, UserId, EmployeeId)
VALUES
(1,1, '2017-04-13', NULL,'Stuck Road on Str.133',6,2),
(6,3, '2015-09-05', '2015-12-06','Charity trail running',3,5),
(14,2, '2015-09-07', NULL,'Falling bricks on Str.58',5,2),
(4,3, '2017-07-03', '2017-07-06','Cut off streetlight on Str.11',1,1)

--03. Update 
UPDATE Reports
SET CloseDate = GETDATE()
WHERE CloseDate IS NULL

--04. Delete 
DELETE FROM Reports
WHERE StatusId = 4

DELETE FROM Status
WHERE Id = 4

--05. Unassigned Reports 
SELECT Description,
       FORMAT(OpenDate, 'dd-MM-yyyy') AS OpenDate
        FROM Reports as r
WHERE EmployeeId IS NULL
ORDER BY r.OpenDate, r.Description

SELECT 
	[Description],
	CONCAT_WS('-', FORMAT(OpenDate, 'dd'), FORMAT(OpenDate, 'MM'), YEAR(OpenDate)) AS OpenDate
	FROM Reports AS r
	WHERE EmployeeId IS NULL
	ORDER BY r.OpenDate, [Description]

--06. Reports & Categories
SELECT  r.Description,
        c.Name
       FROM Reports as r
FULL OUTER JOIN Categories as c
ON r.CategoryId = c.Id
WHERE r.CategoryId IS NOT NULL
ORDER BY r.Description ASC, c.Name ASC

--07. Most Reported Category 
SELECT TOP(5)
       c.Name,
       COUNT(r.CategoryId) AS ReportsNumber
FROM Reports as r
JOIN Categories AS c ON r.CategoryId = c.Id
GROUP BY c.Name, r.CategoryId
ORDER BY ReportsNumber DESC, c.Name ASC

--08. Birthday Report
SELECT u.Username,
        c.Name
          FROM Reports as r
INNER JOIN Users AS u ON r.UserId = u.Id
INNER JOIN Categories AS c ON r.CategoryId = c.Id
WHERE DATEPART(DAY, r.OpenDate) = DATEPART(DAY, u.Birthdate) AND
DATEPART(MONTH, r.OpenDate) = DATEPART(MONTH, u.Birthdate)
ORDER BY  u.Username ASC, c.Name ASC

--09. User per Employee
SELECT 
	CONCAT_WS(' ', e.FirstName, e.LastName) AS FullName,
	(SELECT DISTINCT COUNT(UserId) FROM Reports WHERE EmployeeId = e.Id) AS UsersCount	
	FROM Employees AS e
	GROUP BY e.FirstName, e.LastName, e.Id
	ORDER BY UsersCount DESC, FullName

--10. Full Info
SELECT CASE WHEN e.FirstName IS NULL OR e.LastName IS NULL THEN 'None'
        ELSE CONCAT(e.FirstName, ' ', e.LastName) END AS Employee,
        ISNULL(d.Name,'None') AS Department,
		ISNULL(c.Name,'None') AS Categoty,
		ISNULL(r.Description,'None') AS Description,
		Case WHEN r.OpenDate IS NULL THEN 'None'
		ELSE FORMAT(r.OpenDate, 'dd.MM.yyyy') END AS OpenDate,
		ISNULL(s.Label,'None')  AS Status,
		ISNULL(u.Name, 'None') AS Users
FROM Reports AS r
LEFT JOIN Categories AS c ON r.CategoryId= c.Id
LEFT JOIN Status AS s ON r.StatusId = s.Id
LEFT JOIN Users AS u ON r.UserId = u.Id
LEFT JOIN Employees AS e ON r.EmployeeId = e.Id
LEFT JOIN Departments AS d ON e.DepartmentId = d.Id
ORDER BY e.FirstName DESC, e.LastName DESC, d.Name ASC, c.Name asc, r.Description ASC, r.OpenDate ASC, s.Label asc, u.Name ASC

--11.Hours Òo Complete
CREATE FUNCTION  udf_HoursToComplete(@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT 
AS
BEGIN
	IF(@StartDate IS NULL OR @EndDate IS NULL)
		BEGIN
			RETURN 0
		END
		
	RETURN DATEDIFF(HOUR, @StartDate, @EndDate)
END

--12.Assign Employee
CREATE PROC usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT)
AS
BEGIN
	DECLARE @categoryDepartmentId INT = (SELECT 
											c.DepartmentId 
											FROM Reports AS r 
											JOIN Categories AS c ON c.Id = r.CategoryId 
											WHERE r.Id = @ReportId)
	DECLARE @employeeDepartmentId INT = (SELECT 
											d.Id 
											FROM Employees AS e 
											JOIN Departments AS d ON d.Id = e.DepartmentId 
											WHERE e.Id = @EmployeeId)
	
	IF (@categoryDepartmentId != @employeeDepartmentId)
		THROW 51000, 'Employee doesn''t belong to the appropriate department!', 1; 
	ELSE
		BEGIN
			UPDATE Reports
				SET EmployeeId = @EmployeeId
				WHERE Id = @ReportId
		END
END


