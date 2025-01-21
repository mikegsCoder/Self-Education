SELECT 
	e.job_title,
	CASE 
		WHEN 
			AVG(e.salary) > 46000.000 THEN 'Good'
		WHEN 
			AVG(e.salary) >= 28000.000 THEN 'Medium'
		ELSE 'Need Improvement' 
	END AS "Category"
FROM employees AS e
GROUP BY e.job_title
ORDER BY "Category", e.job_title;
