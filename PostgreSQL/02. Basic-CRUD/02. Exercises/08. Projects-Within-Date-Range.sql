SELECT
	p."name",
	p.start_date,
	p.end_date
FROM projects AS p
WHERE p.start_date >= '2020-10-01 07:00:00'
AND p.end_date < '2024-10-01 00:00:00'
ORDER BY p.start_date;
