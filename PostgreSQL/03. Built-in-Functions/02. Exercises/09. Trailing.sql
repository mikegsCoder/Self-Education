SELECT 
	c.continent_name,
	TRIM(TRAILING FROM c.continent_name)
FROM continents AS c;
