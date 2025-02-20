CREATE OR REPLACE PROCEDURE sp_withdraw_money(
  account_id INTEGER,
  money_amount NUMERIC(19, 4)
) 
LANGUAGE plpgsql
AS $$
BEGIN
  UPDATE accounts 
	SET balance = balance - money_amount 
	WHERE "id" = account_id 
	AND balance - money_amount >= 0;
	IF NOT FOUND THEN
		RAISE NOTICE 'Insufficient balance to withdraw %', money_amount;
	END IF;
END;
$$;

CALL sp_withdraw_money(3, 5050.7500);
CALL sp_withdraw_money(6, 5437.0000);

SELECT 
	a."id", 
	a.account_holder_id, 
	a.balance
FROM accounts AS a
WHERE a."id" = 3;
