CREATE TABLE Users(
Id BIGINT PRIMARY KEY IDENTITY NOT NULL,
Username VARCHAR(30) NOT NULL,
Password VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY(MAX),
LastLoginTime DATETIME,
IsDeleted BIT
)

INSERT INTO Users (Username,Password,LastLoginTime,IsDeleted) VALUES
('Gosho','dadsadg',GETDATE(),1),
('Pesho','321',GETDATE(),0),
('Ivan','dads55adg',GETDATE(),1),
('Mariq','dad22sadg',GETDATE(),0),
('Kaloqn','dad4578sadg',GETDATE(),1)