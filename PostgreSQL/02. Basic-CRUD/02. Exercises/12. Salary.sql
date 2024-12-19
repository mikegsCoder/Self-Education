SELECT
	e.first_name || ' ' || e.last_name AS "Full Name",
	e.job_title,
	e.salary
FROM employees AS e
WHERE e.salary IN (12000, 13000, 23500, 25000)
ORDER BY e.salary DESC;
