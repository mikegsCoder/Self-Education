SELECT 
	LEFT(	u.first_name,	2	) AS initials,
  COUNT(*) AS user_count
FROM users AS u
GROUP BY initials
ORDER BY user_count DESC,	initials;
