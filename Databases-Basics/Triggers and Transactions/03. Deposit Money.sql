CREATE PROC usp_DepositMoney @AccountId INT, @MoneyAmount DECIMAL(15,4)
AS
BEGIN
	IF(@MoneyAmount < 0)
	BEGIN
		RAISERROR('Negative money',16,1)
		RETURN
	END

	UPDATE Accounts
	SET Balance += @MoneyAmount
	WHERE Id = @AccountId
END