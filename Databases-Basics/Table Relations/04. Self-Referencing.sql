CREATE TABLE Teachers(
TeacherID INT PRIMARY KEY NOT NULL,
Name VARCHAR(50) NOT NULL,
ManagerID INT
)

INSERT INTO Teachers VALUES
(101, 'John',	NULL),
(102, 'Maya',	106),
(103, 'Silvia',	106),
(104, 'Ted',	105),
(105, 'Mark',	101),
(106, 'Greta',	101)

ALTER TABLE Teachers
ADD CONSTRAINT FK_Teachers_Teachers FOREIGN KEY(ManagerID) REFERENCES Teachers(TeacherID)