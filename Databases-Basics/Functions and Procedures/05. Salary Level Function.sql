CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(10)
AS
BEGIN
DECLARE @Result VARCHAR(10)

	IF(@salary < 30000)
	BEGIN
		SET @Result = 'Low'
	END
	ELSE IF(@salary >= 30000 AND @salary <= 50000)
	BEGIN
		SET @Result = 'Average'
	END
	ELSE IF(@salary > 50000)
	BEGIN
		SET @Result = 'High'
	END

	RETURN @Result
END