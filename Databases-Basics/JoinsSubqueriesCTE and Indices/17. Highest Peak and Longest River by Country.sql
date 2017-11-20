SELECT TOP 5
rivers.CountryName,
peaks.Elevation AS HighestPeakElevation,
rivers.RiverLength AS LongestRiverLength 
FROM
(
	SELECT c.CountryName,MAX(r.Length) AS RiverLength FROM Rivers AS r
	INNER JOIN CountriesRivers AS cr
	ON cr.RiverId = r.Id
	INNER JOIN Countries AS c
	ON c.CountryCode = cr.CountryCode
	GROUP BY c.CountryName
) AS rivers
INNER JOIN 
(
	SELECT c.CountryName,MAX(p.Elevation) AS Elevation FROM Peaks AS p
	INNER JOIN Mountains AS m
	ON m.Id = p.MountainId
	INNER JOIN MountainsCountries AS mc
	ON mc.MountainId = m.Id
	INNER JOIN Countries AS c
	ON c.CountryCode = mc.CountryCode
	GROUP BY c.CountryName
) AS peaks ON peaks.CountryName = rivers.CountryName
ORDER BY peaks.Elevation DESC, rivers.RiverLength DESC,rivers.CountryName