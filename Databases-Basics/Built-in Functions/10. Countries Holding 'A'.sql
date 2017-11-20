SELECT 
CountryName,
IsoCode AS [ISO Code]
 FROM Countries
 WHERE LEN(CountryName) - LEN(REPLACE(CountryName,'A','')) >= 3
 ORDER BY [ISO Code]