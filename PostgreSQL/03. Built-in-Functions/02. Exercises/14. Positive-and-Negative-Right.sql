SELECT 
	p.peak_name,
	RIGHT( p.peak_name,	4	) AS "Positive Right",
	RIGHT( p.peak_name,	-4 ) AS "Negative Right"
FROM 	peaks AS p;
