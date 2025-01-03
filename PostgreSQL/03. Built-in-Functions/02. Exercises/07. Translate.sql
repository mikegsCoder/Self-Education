SELECT
	c.capital,
	TRANSLATE(c.capital, 'áãåçéíñóú',	'aaaceinou') AS translated_name
FROM countries AS c;
