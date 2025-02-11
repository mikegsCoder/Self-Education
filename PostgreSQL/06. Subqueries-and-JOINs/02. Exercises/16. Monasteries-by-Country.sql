CREATE TABLE monasteries (
  "id" SERIAL PRIMARY KEY,
  monastery_name VARCHAR(255) NOT NULL,
  country_code CHAR(2),
  CONSTRAINT fk_monasteries_countries
	FOREIGN KEY (country_code) 
	REFERENCES countries(country_code)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

INSERT INTO monasteries (monastery_name, country_code) 
VALUES
  ('Rila Monastery “St. Ivan of Rila”', 'BG'),
  ('Bachkovo Monastery “Virgin Mary”', 'BG'),
  ('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
  ('Kopan Monastery', 'NP'),
  ('Thrangu Tashi Yangtse Monastery', 'NP'),
  ('Shechen Tennyi Dargyeling Monastery', 'NP'),
  ('Benchen Monastery', 'NP'),
  ('Southern Shaolin Monastery', 'CN'),
  ('Dabei Monastery', 'CN'),
  ('Wa Sau Toi', 'CN'),
  ('Lhunshigyia Monastery', 'CN'),
  ('Rakya Monastery', 'CN'),
  ('Monasteries of Meteora', 'GR'),
  ('The Holy Monastery of Stavronikita', 'GR'),
  ('Taung Kalat Monastery', 'MM'),
  ('Pa-Auk Forest Monastery', 'MM'),
  ('Taktsang Palphug Monastery', 'BT'),
  ('Sümela Monastery', 'TR');

ALTER TABLE countries
ADD COLUMN 
  three_rivers BOOLEAN NOT NULL DEFAULT false;


UPDATE countries
SET three_rivers = true
WHERE 
	country_code IN (
	  SELECT rivers_count.code
	  FROM (
			SELECT
			  c.country_code AS code,
			  COUNT(cr.river_id) AS countries_rivers
			FROM countries AS c
			JOIN countries_rivers AS cr
				USING(country_code)
			GROUP BY c.country_code
		  ) AS rivers_count
	  WHERE rivers_count.countries_rivers > 3
	);

SELECT
  m.monastery_name AS "Monastery",
  c.country_name AS "Country"
FROM monasteries AS m
JOIN countries c
	USING(country_code)
WHERE NOT c.three_rivers
ORDER BY "Monastery";
