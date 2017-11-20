CREATE TRIGGER tr_EmployeedDelete ON Employees AFTER DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees
	SELECT FirstName,LastName,MiddleName,JobTitle,DepartmentID,Salary
	FROM deleted
END