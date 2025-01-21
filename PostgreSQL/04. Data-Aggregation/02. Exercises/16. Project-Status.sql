SELECT 
	p.project_name,
    CASE
      WHEN 
		p.start_date IS NULL 
		 AND 
		p.end_date IS NULL 
		  THEN 'Ready for development'
        WHEN 
		p.start_date IS NOT NULL 
		 AND p.end_date IS NULL 
		 THEN 'In Progress'
        ELSE 'Done'
     END AS project_status
FROM projects AS p
WHERE p.project_name LIKE '%Mountain%';
