SELECT  TOP 3 e.EmployeeID,e.FirstName FROM Employees AS e
FULL OUTER JOIN EmployeesProjects AS ep
ON ep.EmployeeID = e.EmployeeID
LEFT OUTER JOIN Projects AS p
ON p.ProjectID = ep.ProjectID
WHERE ep.ProjectID IS NULL
ORDER BY e.EmployeeID