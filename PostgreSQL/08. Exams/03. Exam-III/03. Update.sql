UPDATE players_ranges
SET max_players = max_players + 1
WHERE min_players = 2 
	AND max_players = 2
RETURNING *;
