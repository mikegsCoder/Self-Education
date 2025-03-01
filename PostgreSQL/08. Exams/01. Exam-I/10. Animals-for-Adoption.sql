SELECT
  a."name" AS "Animal Name",
  EXTRACT(YEAR FROM a.birthdate) AS "Birth Year",
  at.animal_type AS "Animal Type"
FROM animals AS a
JOIN animal_types AS at 
	ON a.animal_type_id = at."id"
WHERE owner_id IS NULL
  AND a.animal_type_id != 3
  AND EXTRACT(YEAR FROM AGE('01/01/2024', a.birthdate)) < 5
ORDER BY a."name";
