SELECT COUNT(*) AS CountryCode FROM Mountains AS m
FULL OUTER JOIN MountainsCountries AS mc
ON mc.MountainId = m.Id
FULL OUTER JOIN Countries AS c
ON c.CountryCode = mc.CountryCode
WHERE m.MountainRange IS NULL