SELECT
	a."id",
	a."number" || ' ' || a.street AS "Address",
	a.city_id
FROM addresses AS a
WHERE a."id" >= 10;
