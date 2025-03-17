CREATE OR REPLACE FUNCTION fn_creator_with_board_games(
	"name" VARCHAR(30)
)
RETURNS INT
AS $$
DECLARE 
	total_board_games_creator INT;
BEGIN
  total_board_games_creator = 
  (
    SELECT COUNT(cbg.board_game_id)
    FROM creators AS c
    INNER JOIN creators_board_games as cbg
      ON cbg.creator_id = c."id"
    WHERE c.first_name = "name"
  );
  RETURN total_board_games_creator;
END;
$$ 
LANGUAGE plpgsql;

SELECT fn_creator_with_board_games('Bruno');
SELECT fn_creator_with_board_games('Alexander');
