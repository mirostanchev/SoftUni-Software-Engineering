CREATE TABLE People(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(200) NOT NULL,
Picture VARBINARY(MAX),
Height DECIMAL(10,2),
Weight DECIMAL(10,2),
Gender CHAR(1) NOT NULL CHECK(Gender IN ('m','f')),
Birthdate DATE NOT NULL,
Biography NVARCHAR(MAX)
)


INSERT INTO People (Name,Height,Gender,Birthdate,Biography) VALUES
('Gosho',182.42,'m','1992-10-10',NULL),
('Pesho',158.64,'m','1992-10-10',NULL),
('Tosho',177.88,'m','1991-12-12','Master'),
('Mosho',172.01,'m','1993-11-11',NULL),
('Mariq',165.55,'f','1994-09-10',NULL)