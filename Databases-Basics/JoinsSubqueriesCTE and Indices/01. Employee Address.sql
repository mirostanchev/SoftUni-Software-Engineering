SELECT TOP 5
	EmployeeID,
	JobTitle,
	e.AddressID,
	a.AddressText 
	FROM Employees AS e
INNER JOIN Addresses AS a 
ON a.AddressID = e.AddressID
ORDER BY e.AddressID