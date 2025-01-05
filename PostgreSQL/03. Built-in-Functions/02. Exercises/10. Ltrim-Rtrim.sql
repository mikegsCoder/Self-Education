SELECT 
	LTRIM(p.peak_name, 'M') AS "Left Trim",
	RTRIM(p.peak_name, 'm') AS "Right Trim"
FROM peaks AS p;
