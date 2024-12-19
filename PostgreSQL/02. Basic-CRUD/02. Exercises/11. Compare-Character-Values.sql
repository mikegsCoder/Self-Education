SELECT
	p."name",
	p.start_date
FROM projects AS p
WHERE p."name" IN ('Mountain', 'Road', 'Touring')
LIMIT 15;
