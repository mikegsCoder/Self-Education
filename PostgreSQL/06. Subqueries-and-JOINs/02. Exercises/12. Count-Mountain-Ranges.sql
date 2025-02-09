SELECT 
  mc.country_code, 
  COUNT(m.mountain_range) as mountain_range_count
FROM mountains_countries mc
INNER JOIN mountains m ON mc.mountain_id = m.id
WHERE mc.country_code IN ('US', 'RU', 'BG')
GROUP BY mc.country_code
ORDER BY mountain_range_count DESC;
