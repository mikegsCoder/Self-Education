CREATE OR REPLACE FUNCTION fn_cash_in_users_games(
	game_name VARCHAR(50)
)
RETURNS TABLE (total_cash NUMERIC)
LANGUAGE plpgsql
AS $$
BEGIN
  RETURN QUERY
  SELECT ROUND(SUM(cash), 2)
  FROM (
    SELECT cash, 
	  ROW_NUMBER() 
	  OVER (ORDER BY cash DESC) AS row_num
    FROM users_games AS ug
	  INNER JOIN games AS g
      ON ug.game_id = g."id"
    WHERE g."name" = game_name
  ) AS CashList
  WHERE row_num % 2 = 1;
END;
$$;

SELECT * FROM fn_cash_in_users_games('Love in a mist');
SELECT * FROM fn_cash_in_users_games('Delphinium Pacific Giant');
