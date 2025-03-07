SELECT
  cl.full_name,
  COUNT(cl."id") AS count_of_cars,
  SUM(COALESCE (cou.bill, 0)) AS total_sum
FROM clients AS cl
JOIN courses AS cou 
	ON cou.client_id = cl."id"
WHERE SUBSTRING(cl.full_name, 2, 1) = 'a'
GROUP BY cl."id"
HAVING COUNT(cl."id") > 1
ORDER BY cl.full_name;
