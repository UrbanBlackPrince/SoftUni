--CREATE DATABASE [Bitbucket]
--GO

--USE [Bitbucket]
--GO

--01.Database Design

CREATE TABLE Users(
 Id INT PRIMARY KEY IDENTITY,
 UserName VARCHAR(30) NOT NULL,
 [Password] VARCHAR(30) NOT NULL,
 Email VARCHAR(50) NOT NULL
)

CREATE TABLE Repositories(
  Id INT PRIMARY KEY IDENTITY,
  [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE RepositoriesContributors(
  RepositoryId INT NOT NULL FOREIGN KEY REFERENCES Repositories(Id),
  ContributorId INT NOT NULL FOREIGN KEY REFERENCES Users(Id),
  PRIMARY KEY (RepositoryId, ContributorId)
)

CREATE TABLE Issues(
 Id INT PRIMARY KEY IDENTITY,
 Title VARCHAR(255) NOT NULL,
 IssueStatus VARCHAR(6) NOT NULL,
 RepositoryId INT NOT NULL FOREIGN KEY REFERENCES Repositories(Id),
 AssigneeId INT NOT NULL FOREIGN KEY REFERENCES Users(Id)
)

CREATE TABLE Commits(
 Id INT PRIMARY KEY IDENTITY,
 [Message] VARCHAR(255) NOT NULL,
 IssueId INT FOREIGN KEY REFERENCES Issues(Id),
 RepositoryId INT NOT NULL FOREIGN KEY REFERENCES Repositories(Id),
 ContributorId INT NOT NULL FOREIGN KEY REFERENCES Users(Id)
)

CREATE TABLE Files(
 Id INT PRIMARY KEY IDENTITY,
 [Name] VARCHAR(100) NOT NULL,
 Size DECIMAL (15,2) NOT NULL,
 ParentId INT NOT NULL FOREIGN KEY REFERENCES Files(Id),
 CommitId INT NOT NULL FOREIGN KEY REFERENCES Commits(Id)
)

--02.Insert
INSERT INTO Files([Name], Size, ParentId, CommitId)
VALUES
 ('Trade.idk', 2598.0, 1, 1),
 ('menu.net', 9238.31, 2, 2),
 ('Administrate.soshy', 1246.93, 3, 3),
 ('Controller.php', 7353.15, 4, 4),
 ('Find.java', 9957.86, 5, 5),
 ('Controller.json', 14034.87, 3, 6),
 ('Operate.xix', 7662.92,7, 7)

 INSERT INTO Issues(Title,IssueStatus, RepositoryId, AssigneeId)
 Values
 ('Critical Problem with HomeController.cs file','open',1,4),
 ('Typo fix in Judge.html', 'open', 4, 3),
 ('Implement documentation for UsersService.cs', 'closed', 8, 2),
 ('Unreachable code in Index.cs', 'open', 9, 8)

 --03. Update
 UPDATE Issues
SET IssueStatus = 'closed'
WHERE AssigneeId = 6

--04. Delete
DELETE FROM RepositoriesContributors
WHERE RepositoryId = (
  SELECT Id
  FROM Repositories
  WHERE Name = 'SoftUni-Teamwork'
)

DELETE FROM Issues
 WHERE RepositoryId = (
  SELECT Id
  FROM Repositories
  WHERE Name = 'SoftUni-Teamwork'
 )

 --05. Commits
 SELECT Id, Message, RepositoryId, ContributorId FROM Commits
ORDER BY Id ASC, [Message] ASC, RepositoryId ASC, ContributorId ASC

--06. Front-end
SELECT Id,[Name],Size FROM Files
WHERE Size > 1000 AND [Name] LIKE '%html%'
ORDER BY Size DESC, [Name] Asc, Id ASC

--07. Issue Assigment
SELECT [i].[Id],
  CONCAT([u].[Username], ' : ', [i].[Title])
  AS [IssueAssignee]
  FROM [Issues]
  AS [i]
  INNER JOIN [Users]
  AS [u]
  On [i].[AssigneeId] = [u].[Id]
 ORDER BY [i].[Id] DESC, [IssueAssignee]


 SELECT * FROM [Issues] AS [i]
  INNER JOIN [USERS] AS [U]
  ON [i].[AssigneeId] = [u].[Id]

  --08. Single Files
  SELECT [b].[Id], [b].[Name], CONCAT([b].[Size], 'KB') AS [Size]
FROM [Files] AS [a]
FULL OUTER JOIN [Files] AS [b]
ON [a].[Id] = [b].[ParentId]
WHERE [a].[Id] IS NULL
ORDER BY [b].[Id] ASC, [b].[Name] ASC, [b].[Size] ASC

--09. Commits in Repositories
SELECT TOP(5)
[r].[Id],
[r].[Name],
COUNT([c].[Id])
 AS [Commits]
 FROM [Repositories]
 AS [r]
 INNER JOIN [Commits]
 AS [c]
 ON [c].[RepositoryId] = [r].[Id]
 INNER JOIN [RepositoriesContributors]
 AS[rc]
 ON [rc].[RepositoryId] = [r].[Id]
 GROUP BY [r].[Id], [r].[Name]
 ORDER BY [Commits] DESC, [r].[Id], [r].[Name]

 --10. Average Size
 SELECT [u].[UserName] ,
AVG([f].[Size]) AS [Size]
FROM [Users] AS [u]
INNER JOIN [Commits] AS [c]
ON [u].[Id] = [c].[Id]
INNER JOIN [Files] AS [f]
ON [f].[Id] = [u].[Id]
GROUP BY [u].[UserName]
ORDER BY [Size] DESC, [u].[UserName]

--11. All User Commits
CREATE FUNCTION udf_AllUserCommits(@username VARCHAR (30))
RETURNS INT
AS
BEGIN
  DECLARE @userId INT = (
    SELECT [Id] 
	FROM [Users]
	WHERE [Username] = @username
  )

  DECLARE @commitsCnt INT = (
   SELECT COUNT ([Id]) FROM [Commits]
   WHERE [ContributorId] = @userId
  )

  RETURN @commitsCnt
END

GO

SELECT dbo.udf_AllUserCommits('UnderSinduxrein')

--12. Search For Files
CREATE PROC usp_SearchForFiles @fileExtension VARCHAR(98)
AS
BEGIN
  SELECT [f].[Id],
         [f].[Name],
		 CONCAT([f].[Size], 'KB')
	AS [Size]
	FROM [Files]
	AS [f]
WHERE [Name] LIKE CONCAT('%[.]', @fileExtension)
ORDER BY [f].[Id], [f].[Name], [f].[Size] DESC
END

GO

EXEC usp_SearchForFiles 'txt'
