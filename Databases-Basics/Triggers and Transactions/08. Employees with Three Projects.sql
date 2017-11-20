CREATE PROC usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO EmployeesProjects VALUES
		(@emloyeeId,@projectID)

		IF((SELECT COUNT(*) FROM EmployeesProjects WHERE EmployeeID = @emloyeeId) > 3)
		BEGIN 
			ROLLBACK
			RAISERROR('The employee has too many projects!',16,1)
			RETURN
		END
	COMMIT
END