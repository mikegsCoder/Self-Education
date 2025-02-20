CREATE OR REPLACE PROCEDURE sp_deposit_money(
  account_id INTEGER,
  money_amount NUMERIC(19, 4)
) 
LANGUAGE plpgsql
AS $$
BEGIN 
  UPDATE accounts 
	SET balance = balance + money_amount 
	WHERE "id" = account_id;
END;
$$;

CALL sp_deposit_money(1, 200);
CALL sp_deposit_money(10, 500);
CALL sp_deposit_money(14, 1000);

SELECT 
	a."id", 
	a.account_holder_id, 
	a.balance
FROM accounts AS a
WHERE a."id" = 1;
