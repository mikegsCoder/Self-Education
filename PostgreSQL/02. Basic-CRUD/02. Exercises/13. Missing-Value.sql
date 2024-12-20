SELECT
	e."id",
	e.first_name,
	e.last_name
FROM employees AS e
WHERE e.middle_name IS NULL
LIMIT 2;
