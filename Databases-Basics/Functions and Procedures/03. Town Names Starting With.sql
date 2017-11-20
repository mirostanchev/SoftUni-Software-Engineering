CREATE PROC usp_GetTownsStartingWith @Pattern NVARCHAR(20)
AS
BEGIN
	DECLARE @NumberOfChars INT = LEN(@Pattern)

	SELECT Name FROM Towns
	WHERE LEFT(Name,@NumberOfChars) = @Pattern
END