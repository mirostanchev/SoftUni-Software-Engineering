SELECT Peaks.PeakName,
Rivers.RiverName,
LOWER(LEFT(Peaks.PeakName,LEN(Peaks.PeakName) - 1) + Rivers.RiverName) AS Mix
 FROM Peaks
JOIN Rivers ON RIGHT(Peaks.PeakName,1) = LEFT(Rivers.RiverName,1)
ORDER BY Mix