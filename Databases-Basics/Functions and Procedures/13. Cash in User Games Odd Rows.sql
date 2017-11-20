CREATE FUNCTION ufn_CashInUsersGames (@gameName VARCHAR(100))
RETURNS TABLE
AS
RETURN
SELECT SUM(tempTable.Cash) AS SumCash FROM 
(SELECT SUM(Cash) AS Cash,ROW_NUMBER() OVER(ORDER BY Cash DESC) AS Row FROM UsersGames
WHERE GameId = (SELECT Id FROM Games WHERE Name = @gameName)
GROUP BY GameId,Cash) AS tempTable
WHERE tempTable.Row % 2 != 0