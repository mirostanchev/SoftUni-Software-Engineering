CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL,
Title NVARCHAR(100),
Notes NVARCHAR(1000)
)

CREATE TABLE Customers(
AccountNumber VARCHAR(30) PRIMARY KEY NOT NULL,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL,
PhoneNumber VARCHAR(20),
EmergencyName NVARCHAR(50),
EmergencyNumber VARCHAR(20),
Notes NVARCHAR(1000)
)

CREATE TABLE RoomStatus(
RoomStatus NVARCHAR(100) PRIMARY KEY NOT NULL,
Notes NVARCHAR(1000)
)

CREATE TABLE RoomTypes(
RoomType NVARCHAR(50) PRIMARY KEY NOT NULL,
Notes NVARCHAR(1000)
)

CREATE TABLE BedTypes(
BedType NVARCHAR(50) PRIMARY KEY NOT NULL,
Notes NVARCHAR(1000)
)

CREATE TABLE Rooms(
RoomNumber SMALLINT NOT NULL,
RoomType NVARCHAR(50) FOREIGN KEY REFERENCES RoomTypes(RoomType),
BedType NVARCHAR(50) FOREIGN KEY REFERENCES BedTypes(BedType),
Rate NUMERIC,
RoomStatus NVARCHAR(100) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
Notes NVARCHAR(1000)
)

CREATE TABLE Payments(
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
PaymentDate DATE NOT NULL,
AccountNumber VARCHAR(30) FOREIGN KEY REFERENCES Customers(AccountNumber),
FirstDateOccupied DATE,
LastDateOccupied DATE,
TotalDays AS DATEDIFF(DAY,FirstDateOccupied,LastDateOccupied),
AmountCharged NUMERIC NOT NULL,
TaxRate NUMERIC,
TaxAmount NUMERIC,
PaymentTotal NUMERIC NOT NULL,
Notes NVARCHAR(1000)
)

ALTER TABLE Rooms
ADD CONSTRAINT PK_Rooms
PRIMARY KEY(RoomNumber)

CREATE TABLE Occupancies (
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
DateOccupied DATE,
AccountNumber VARCHAR(30) FOREIGN KEY REFERENCES Customers(AccountNumber),
RoomNumber SMALLINT FOREIGN KEY REFERENCES Rooms(RoomNumber),
RateApplied NUMERIC,
PhoneCharge NUMERIC,
Notes NVARCHAR(1000)
)

INSERT INTO Employees (FirstName,LastName) VALUES
('Ivan','Petrov'),
('Gosho','Georgiev'),
('Petur','Ivanov')

INSERT INTO Customers(FirstName,LastName,AccountNumber) VALUES
('Pesho','Peshov','359A'),
('Gosho','Peshov','359B'),
('Ivan','Peshov','359C')

INSERT INTO RoomStatus(RoomStatus) VALUES
('Occupied'),
('Cleaning in progress'),
('Free')

INSERT INTO RoomTypes(RoomType) VALUES
('Single'),
('Double'),
('Duplex')

INSERT INTO BedTypes(BedType) VALUES
('Twin'),
('Standart'),
('King')


INSERT INTO Rooms(RoomNumber,RoomType,BedType,RoomStatus) VALUES
(1,'Single','Standart','Free'),
(2,'Double','Twin','Free'),
(3,'Duplex','King','Occupied')

INSERT INTO Payments(EmployeeId,PaymentDate,AccountNumber,AmountCharged,PaymentTotal) VALUES 
(1,'2012-10-10','359A',354.22,321.45),
(2,'2012-10-12','359B',354.22,321.45),
(3,'2012-10-11','359C',354.22,321.45)

INSERT INTO Occupancies(EmployeeId,AccountNumber,RoomNumber) VALUES 
(1,'359A',2),
(2,'359B',3),
(3,'359C',1)