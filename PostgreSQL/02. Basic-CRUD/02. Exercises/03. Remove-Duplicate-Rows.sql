SELECT 
	DISTINCT ON 
	(c."name") c."name", 
	c.area AS "Area (km2)"
FROM cities AS c
ORDER BY c."name" DESC;
