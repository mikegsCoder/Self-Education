SELECT
	a."number",
	a.street
FROM addresses AS a
WHERE a."id" BETWEEN 50 AND 120 
OR a."number" < 1300;
