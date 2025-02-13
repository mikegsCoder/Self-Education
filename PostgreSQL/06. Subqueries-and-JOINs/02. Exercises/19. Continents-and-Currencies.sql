CREATE VIEW continent_currency_usage AS
SELECT 
	ordered_currencies.continent_code,
	ordered_currencies.currency_code,
	ordered_currencies.currency_usage
FROM continents AS c
JOIN (
	SELECT 
		continent_code,
		COUNT(currency_code) AS currency_usage,
		currency_code,
		DENSE_RANK() OVER (
			PARTITION BY continent_code
			ORDER BY COUNT(currency_code) DESC
		) AS Rank
		FROM countries
		GROUP BY 
			continent_code, 
			currency_code
		HAVING COUNT(currency_code) > 1
		ORDER BY currency_usage DESC
	) AS ordered_currencies
  USING(continent_code)
WHERE ordered_currencies.Rank = 1;
