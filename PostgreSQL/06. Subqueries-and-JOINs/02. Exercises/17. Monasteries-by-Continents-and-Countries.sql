UPDATE countries
SET country_name = 'Burma'
WHERE country_name = 'Myanmar';

INSERT INTO monasteries (monastery_name, country_code)
	(
	  SELECT
	  	'Hanga Abbey',
	  	country_code
	  FROM countries
	  WHERE country_name = 'Tanzania'
	);

INSERT INTO monasteries (monastery_name, country_code)
	(
	  SELECT
	  	'Myin-Tin-Daik',
	  	country_code
	  FROM countries
	  WHERE country_name = 'Myanmar'
	);

SELECT
	con.continent_name AS "Continent Name",
	c.country_name AS "Country Name",
	COUNT(m."id") AS "Monasteries Count"
FROM continents AS con
JOIN countries AS c
	USING(continent_code)
LEFT JOIN monasteries AS m
	USING(country_code)
WHERE c.three_rivers = false
GROUP BY 
	c.country_name, 
	con.continent_name
ORDER BY 
	"Monasteries Count" DESC, 
	"Country Name";
