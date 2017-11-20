SELECT TOP 5 c.CountryName,r.RiverName FROM Rivers AS r
FULL OUTER JOIN CountriesRivers AS cr
ON cr.RiverId = r.Id
 FULL OUTER JOIN Countries AS c
ON c.CountryCode = cr.CountryCode
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName