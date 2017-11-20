CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
CategoryName NVARCHAR(100) NOT NULL,
DailyRate NUMERIC,
WeeklyRate NUMERIC,
MonthlyRate NUMERIC,
WeekendRate NUMERIC
)

CREATE TABLE Cars(
Id INT PRIMARY KEY IDENTITY,
PlateNumber NVARCHAR(20) NOT NULL,
Manufacturer NVARCHAR(100) NOT NULL,
Model NVARCHAR(100) NOT NULL,
CarYear SMALLINT NOT NULL,
CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
Doors SMALLINT,
Picture VARBINARY(MAX),
Condition NVARCHAR(200),
Available BIT NOT NULL
)

CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50) NOT NULL,
Title NVARCHAR(200),
Notes NVARCHAR(1000)
)

CREATE TABLE Customers(
Id INT PRIMARY KEY IDENTITY,
DriverLicenceNumber VARCHAR(50),
FullName NVARCHAR(100) NOT NULL,
Address NVARCHAR(200) NOT NULL,
City NVARCHAR(100) NOT NULL, 
ZIPCode VARCHAR(100),
Notes NVARCHAR(1000)
)

CREATE TABLE RentalOrders(
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employees(Id),
CustomerId INT NOT NULL FOREIGN KEY REFERENCES Customers(Id),
CarId INT NOT NULL FOREIGN KEY REFERENCES Cars(Id),
TankLevel NUMERIC,
KilometrageStart NUMERIC,
KilometrageEnd NUMERIC,
TotalKilometrage NUMERIC,
StartDate DATE,
EndDate DATE,
TotalDays AS DATEDIFF(DAY,StartDate,EndDate),
RateApplied NUMERIC,
TaxRate NUMERIC,
OrderStatus NVARCHAR(50),
Notes NVARCHAR(1000)
)

INSERT INTO Categories (CategoryName) VALUES
('Sport'),
('Classic'),
('Offroad')

INSERT INTO Cars (PlateNumber,Manufacturer,Model,CarYear,CategoryId,Available) VALUES
('DSANFR','BMW','M3',2003,1,1),
('FIFORME','BMW','X5',2004,3,1),
('GTGTQ','BMW','320',2005,2,1)

INSERT INTO Employees (FirstName,LastName) VALUES
('Ivan','Petrov'),
('Gosho','Ivanov'),
('Stefan','Georgiev')

INSERT INTO Customers (FullName,Address,City) VALUES
('Pesho Ivanov','fdsadasdas','Sofia'),
('Gosho Petrov','feinfom','Plovdiv'),
('Ivo Ivanov','fewmrokgtu','Varna')

INSERT INTO RentalOrders (EmployeeId,CustomerId,CarId) VALUES 
(1,2,3),
(1,3,2),
(3,2,1)
