SELECT 
	c.continent_name,
	TRIM(LEADING FROM c.continent_name)
FROM continents AS c;
