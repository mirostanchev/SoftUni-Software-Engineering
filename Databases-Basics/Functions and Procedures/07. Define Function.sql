CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
	DECLARE @startIndex INT = 1
	DECLARE @lastIndex INT = LEN(@word)

	WHILE(@startIndex <= @lastIndex)
	BEGIN
		DECLARE @char CHAR(1) = SUBSTRING(@word,@startIndex,1)
		DECLARE @index INT = CHARINDEX(@char,@setOfLetters)

		IF(@index <= 0)
		BEGIN
			RETURN 0
		END

		SET @startIndex += 1
	END

	RETURN 1
END