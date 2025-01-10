SELECT
	u.companion_full_name,
	u.email
FROM users AS u
WHERE 
	u.companion_full_name ILIKE '%aNd%' AND
	u.email NOT LIKE '%@gmail';
