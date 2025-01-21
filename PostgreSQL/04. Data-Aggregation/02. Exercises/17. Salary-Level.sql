SELECT 
  e.department_id, 
  COUNT(*) AS num_employees, 
  CASE 
    WHEN AVG(e.salary) > 50000 THEN 'Above average' 
    ELSE 'Below average' 
  END AS salary_level
FROM employees AS e
GROUP BY e.department_id
HAVING AVG(e.salary) > 30000
ORDER BY e.department_id;
