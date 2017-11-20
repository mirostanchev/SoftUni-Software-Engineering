CREATE PROC usp_TransferMoney @SenderId INT, @ReceiverId INT, @Amount DECIMAL(15,4)
AS
BEGIN TRANSACTION
	EXEC usp_WithdrawMoney @SenderiD, @Amount
	EXEC dbo.usp_DepositMoney @ReceiverId,@Amount

	DECLARE @senderBalance DECIMAL(15,4) = (SELECT Balance From Accounts WHERE Id = @SenderId)

	IF (@senderBalance < 0)
	BEGIN
		ROLLBACK
		RETURN
	END
COMMIT