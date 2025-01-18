SELECT 
	wd.last_name,
	COUNT(wd.notes) AS "Notes_with_Dumbledore"
FROM wizard_deposits AS wd
WHERE wd.notes LIKE '%Dumbledore%'
GROUP BY wd.last_name;
