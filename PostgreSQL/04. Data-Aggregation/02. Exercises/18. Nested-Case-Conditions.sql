CREATE VIEW view_performance_rating AS 
SELECT 
  e.first_name, 
  e.last_name, 
  e.job_title, 
  e.salary, 
  e.department_id, 
  CASE 
    WHEN e.salary >= 25000 THEN 
      CASE 
        WHEN 
			    e.job_title LIKE 'Senior%' THEN 'High-performing Senior' 
        ELSE 'High-performing Employee' 
      END 
    ELSE 'Average-performing' 
  END AS performance_rating
FROM employees AS e;
