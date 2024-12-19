SELECT
	ep.employee_id,
	ep.project_id
FROM employees_projects AS ep
WHERE ep.employee_id IN (100, 150) 
AND ep.project_id NOT IN (60, 80);
