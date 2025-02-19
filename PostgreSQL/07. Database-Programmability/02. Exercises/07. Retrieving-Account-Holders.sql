CREATE OR REPLACE PROCEDURE sp_retrieving_holders_with_balance_higher_than(
  IN searched_balance NUMERIC
)
LANGUAGE plpgsql
AS $$
DECLARE
  holder RECORD;
  total_balance NUMERIC;
BEGIN
  FOR 
	holder IN SELECT 
		"id", 
		first_name, 
		last_name 
	FROM account_holders 
	ORDER BY 
		first_name, 
		last_name
  LOOP
    SELECT 
		SUM(balance) 
		INTO total_balance 
	  FROM accounts 
	  WHERE account_holder_id = holder."id";

    IF total_balance > searched_balance THEN
      RAISE NOTICE 
		'% % - %', 
		holder.first_name, 
		holder.last_name, 
		total_balance;
    END IF;
  END LOOP;
END;
$$;

CALL sp_retrieving_holders_with_balance_higher_than(200000);
