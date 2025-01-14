SELECT 
  id, 
  first_name, 
  last_name, 
	TRUNC(salary, 2) AS salary, 
  department_id,
	CASE department_id
    WHEN 1 THEN 'Management'
    WHEN 2 THEN 'Kitchen_Staff'
    WHEN 3 THEN 'Service_Staff'
	ELSE 'Other'
	END AS department_name
FROM employees 
ORDER BY id;
