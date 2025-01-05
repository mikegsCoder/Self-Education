SELECT 
	c.population,
	LENGTH(CAST(c.population AS TEXT))
FROM countries AS c;
