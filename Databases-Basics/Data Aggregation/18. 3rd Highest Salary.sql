SELECT salaries.DepartmentID AS DepartmentID, salaries.Salary AS ThirdHighestSalary FROM
(
SELECT DepartmentId,
 MAX(Salary) AS Salary,
 DENSE_RANK() OVER(PARTITION BY DepartmentId ORDER BY Salary DESC) AS Rank
 FROM Employees
 GROUP BY DepartmentID,Salary
 ) AS salaries
 WHERE salaries.Rank = 3