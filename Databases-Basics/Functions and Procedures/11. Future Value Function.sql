CREATE FUNCTION ufn_CalculateFutureValue(@Sum DECIMAL(15,4),@InterestRate FLOAT,@NumberOfYears INT)
RETURNS DECIMAL(15,4)
AS
BEGIN
	DECLARE @Result DECIMAL(15,4) = @Sum * POWER((1 + @InterestRate),@NumberOfYears)
	RETURN @Result
END