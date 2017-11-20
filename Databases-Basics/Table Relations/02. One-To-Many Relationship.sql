CREATE TABLE Manufacturers(
	ManufacturerID INT NOT NULL,
	Name VARCHAR(50) NOT NULL,
	EstablishedOn DATE NOT NULL
)

CREATE TABLE Models(
	ModelID INT NOT NULL,
	Name VARCHAR(50) NOT NULL,
	ManufacturerID INT NOT NULL
)

INSERT INTO Manufacturers VALUES
(1,'BMW', '07/03/1916'),
(2,	'Tesla', '01/01/2003'),
(3,	'Lada',	'01/05/1966')

INSERT INTO Models VALUES
(101, 'X1', 1),
(102, 'i6' ,1),
(103, 'Model S', 2),
(104, 'Model X', 2),
(105, 'Model 3', 2),
(106, 'Nova', 3)

ALTER TABLE Manufacturers
ADD PRIMARY KEY(ManufacturerID)

ALTER TABLE Models
ADD PRIMARY KEY (ModelID)

ALTER TABLE Models
ADD FOREIGN KEY(ManufacturerID) REFERENCES Manufacturers(ManufacturerID)