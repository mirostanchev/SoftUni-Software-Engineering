CREATE TABLE Directors(
Id INT PRIMARY KEY NOT NULL,
DirectorName NVARCHAR(50) NOT NULL,
Notes NVARCHAR(100)
)

CREATE TABLE Genres(
Id INT PRIMARY KEY NOT NULL,
GenreName NVARCHAR(50) NOT NULL,
Notes NVARCHAR(100)
)


CREATE TABLE Categories(
Id INT PRIMARY KEY NOT NULL,
CategoryName NVARCHAR(50) NOT NULL,
Notes NVARCHAR(100)
)

CREATE TABLE Movies(
Id INT PRIMARY KEY NOT NULL,
Title NVARCHAR(200) NOT NULL,
DirectorId INT NOT NULL FOREIGN KEY REFERENCES Directors(Id),
CopyrightYear INT NOT NULL,
Length DECIMAL(15,2) NOT NULL,
GenreId INT NOT NULL FOREIGN KEY REFERENCES Genres(Id),
CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
Rating DECIMAL,
Notes NVARCHAR(100)
)

INSERT INTO Categories (Id, CategoryName,Notes) VALUES
(1,'Action','Something'),
(2,'Action2','Something2'),
(3,'Action3','Something3'),
(4,'Action4','Something4'),
(5,'Action5','Something5')

INSERT INTO Directors VALUES 
(1,'Ivan','THE BOSS1'),
(2,'Pesho','THE BOSS2'),
(3,'Gosho','THE BOSS3'),
(4,'Kiro','THE BOSS4'),
(5,'Petur','THE BOSS5')

INSERT INTO Genres VALUES
(1,'Comedy',NULL),
(2,'Horror','Creepy'),
(3,'Fantasy',NULL),
(4,'Adventure',NULL),
(5,'Crime',NULL)

INSERT INTO Movies (Id,Title,DirectorId,CopyrightYear,Length,GenreId,CategoryId) VALUES
(1,'Movie1',3,1994,111.12,2,4),
(2,'Movie2',1,1995,101.12,4,3),
(3,'Movie3',4,1996,131.12,3,1),
(4,'Movie4',5,1997,161.12,1,5),
(5,'Movie5',1,19948,91.12,5,2)