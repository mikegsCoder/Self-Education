SELECT 
	CONCAT_WS(' ', c.first_name, c.last_name) AS full_name,
	c.email,
	MAX(bg.rating) AS rating
FROM creators_board_games AS cbg
JOIN creators AS c
	ON cbg.creator_id = c."id"
JOIN board_games AS bg
	ON cbg.board_game_id = bg."id"
WHERE c.email LIKE '%.com'
GROUP BY 
	full_name,
	email
ORDER BY full_name;
