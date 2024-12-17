SELECT
	e."id" AS "ID",
	e.first_name || ' ' || e.last_name AS "Full Name",
	e.job_title AS "Job Title"
FROM employees AS e
ORDER BY e.first_name
LIMIT 40;
