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
