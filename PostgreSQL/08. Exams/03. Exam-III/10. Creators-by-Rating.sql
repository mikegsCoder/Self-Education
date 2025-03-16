SELECT 
  c.last_name,
  CEILING(AVG(bg.rating)) AS average_rating,
  p."name" AS publisher_name
FROM creators AS c
JOIN creators_board_games AS cbg 
	ON cbg.creator_id = c."id"
JOIN board_games AS bg 
	ON cbg.board_game_id = bg."id"
JOIN publishers AS p
	ON bg.publisher_id = p."id"
WHERE cbg.creator_id IS NOT NULL 
  AND p."name" = 'Stonemaier Games'
GROUP BY 
  c.last_name, 
  p."name"
ORDER BY average_rating DESC;
