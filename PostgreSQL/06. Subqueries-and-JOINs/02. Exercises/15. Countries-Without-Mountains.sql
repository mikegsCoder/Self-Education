SELECT COUNT(*) AS countries_without_mountains
FROM (
  SELECT mc.country_code
  FROM countries AS c
  LEFT JOIN mountains_countries AS mc
  USING(country_code)
  WHERE mc.country_code IS NULL
  ) AS countries_without_mountains;
