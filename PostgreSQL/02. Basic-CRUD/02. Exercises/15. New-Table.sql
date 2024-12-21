CREATE TABLE IF NOT EXISTS company_chart AS 
SELECT
	e.first_name || ' ' || e.last_name AS "Full Name",
	e.job_title AS "Job Title",
	e.department_id AS "Department ID",
	e.manager_id AS "Manager ID"
FROM employees AS e;
