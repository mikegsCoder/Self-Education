SELECT
	e."id",
	e.first_name || ' ' || e.middle_name || ' ' || e.last_name AS "Full Name",
	e.hire_date AS "Hire Date"
FROM employees AS e
ORDER BY e.hire_date
OFFSET 5;
