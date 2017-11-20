SELECT c.CountryCode,COUNT(*) AS MountainRanges FROM Mountains AS m
INNER JOIN MountainsCountries AS mc
ON mc.MountainId = m.Id
INNER JOIN Countries AS c
ON c.CountryCode = mc.CountryCode
WHERE c.CountryName IN ('United States', 'Russia', 'Bulgaria')
GROUP BY c.CountryCode