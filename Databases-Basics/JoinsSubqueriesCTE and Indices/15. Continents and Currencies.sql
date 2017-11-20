SELECT currencies.ContinentCode,currencies.CurrencyCode,currencies.CurrencyUsage FROM
(
SELECT 
co.ContinentCode,
c.CurrencyCode,
COUNT(*) AS CurrencyUsage,
DENSE_RANK() OVER(PARTITION BY co.ContinentCode ORDER BY COUNT(*) desc)  AS [Rank]
FROM Countries AS c
JOIN Continents AS co
ON co.ContinentCode = c.ContinentCode
GROUP BY co.ContinentCode,c.CurrencyCode
) AS currencies
WHERE currencies.Rank = 1 and currencies.CurrencyUsage > 1
ORDER BY currencies.ContinentCode,currencies.CurrencyCode