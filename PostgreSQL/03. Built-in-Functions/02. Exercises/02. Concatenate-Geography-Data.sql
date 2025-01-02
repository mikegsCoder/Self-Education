CREATE VIEW view_continents_countries_currencies_details AS 
SELECT 
	CONCAT_WS(
		': ',
		con.continent_name,
		con.continent_code
	) AS "Continent Details",
	CONCAT_WS(
		' - ',
		c.country_name,
		c.capital,
		c.area_in_sq_km,
		'km2'
	) AS "Country Information",
	CONCAT(
		cur.description,
		' (', cur.currency_code, ')') AS "Currencies"
FROM 
	continents AS con,
	countries AS c, 	
	currencies AS cur
WHERE c.currency_code = cur.currency_code 
AND c.continent_code = con.continent_code
ORDER BY "Country Information",	"Currencies";
