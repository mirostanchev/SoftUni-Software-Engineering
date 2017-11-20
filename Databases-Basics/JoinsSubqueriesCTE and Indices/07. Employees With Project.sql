SELECT TOP 5
e.EmployeeID,
e.FirstName,
p.Name
FROM Employees AS e
INNER JOIN EmployeesProjects AS ep
ON ep.EmployeeID = e.EmployeeID
INNER JOIN Projects AS p
ON p.ProjectID = ep.ProjectID AND p.StartDate > '08/13/2002'
WHERE p.EndDate IS NULL
ORDER BY e.EmployeeID