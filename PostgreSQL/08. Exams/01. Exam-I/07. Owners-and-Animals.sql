SELECT 
	o."name" AS "Owner", 
	COUNT(*) AS "Count of animals"
FROM owners AS o
JOIN animals AS a 
	ON a.owner_id = o."id"
GROUP BY o."name"
ORDER BY 
	"Count of animals" DESC, 
	"Owner"
LIMIT 5;
