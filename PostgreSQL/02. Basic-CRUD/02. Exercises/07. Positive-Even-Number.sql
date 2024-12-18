SELECT
  a."number" || ' ' || a.street AS "Address",
  a.city_id
FROM addresses AS a
WHERE a.city_id % 2 = 0
ORDER BY a.city_id;
