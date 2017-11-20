CREATE TABLE Logs
(
  LogID INT NOT NULL IDENTITY,
  AccountID INT FOREIGN KEY REFERENCES Accounts(Id),
  OldSum MONEY,
  NewSum MONEY,
)

GO

CREATE TRIGGER tr_AccountsUpdate ON Accounts FOR UPDATE
AS
BEGIN
	INSERT INTO Logs(AccountId,OldSum,NewSum)
	SELECT deleted.Id,deleted.Balance,inserted.Balance FROM inserted
	INNER JOIN deleted ON inserted.Id = deleted.ID
END