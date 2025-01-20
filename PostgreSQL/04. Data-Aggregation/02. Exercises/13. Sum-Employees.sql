SELECT 
 	SUM( CASE e.department_id	WHEN 1 THEN 1 ELSE 0 END) "Engineering",
 	SUM( CASE e.department_id WHEN 2 THEN 1 ELSE 0 END) "Tool Design",
	SUM( CASE e.department_id WHEN 3 THEN 1 ELSE 0 END) "Sales",
	SUM( CASE e.department_id	WHEN 4 THEN 1 ELSE 0 END) "Marketing",
	SUM( CASE e.department_id	WHEN 5 THEN 1 ELSE 0 END) "Purchasing",
	SUM( CASE e.department_id	WHEN 6 THEN 1 ELSE 0 END) "Research and Development",
	SUM( CASE e.department_id WHEN 7 THEN 1 ELSE 0 END) "Production"
FROM employees AS e;
