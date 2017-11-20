CREATE PROC usp_GetHoldersWithBalanceHigherThan @Number DECIMAL(15,2)
AS
BEGIN
	SELECT ah.FirstName,ah.LastName FROM Accounts AS a
	JOIN AccountHolders AS ah
	ON ah.Id = a.AccountHolderId
	GROUP BY ah.FirstName,ah.LastName
	HAVING SUM(Balance) > @Number
END