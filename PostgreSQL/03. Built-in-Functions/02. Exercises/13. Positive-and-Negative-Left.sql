SELECT 
	p.peak_name,
	LEFT( p.peak_name, 4 ) AS "Positive Left",
	LEFT(	p.peak_name, -4	) AS "Negative Left"
FROM 	peaks AS p;
