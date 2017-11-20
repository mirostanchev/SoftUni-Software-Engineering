CREATE TABLE NotificationEmails
(
 Id INT NOT NULL IDENTITY,
 Recipient INT FOREIGN KEY REFERENCES Accounts(Id),
 [Subject] VARCHAR(50),
 Body TEXT
)

GO

CREATE TRIGGER tr_Logs_Insert ON Logs AFTER INSERT
AS
BEGIN
	INSERT INTO NotificationEmails
	SELECT inserted.AccountId,
	'Balance change for account: ' + CAST(inserted.AccountId AS VARCHAR),
	'On ' + CAST(GETDATE() AS VARCHAR) + 'your balance was changed from ' + CAST(inserted.OldSum AS VARCHAR) + ' to ' + CAST(inserted.NewSum AS VARCHAR) + '.'
	 FROM inserted
END