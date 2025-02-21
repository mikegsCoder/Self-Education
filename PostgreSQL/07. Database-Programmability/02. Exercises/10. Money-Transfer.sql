CREATE OR REPLACE PROCEDURE sp_transfer_money(
  sender_id INTEGER,
  receiver_id INTEGER,
  amount NUMERIC(19, 4)
) 
LANGUAGE plpgsql
AS $$
DECLARE
  success BOOLEAN = true;
BEGIN
  BEGIN
    CALL sp_withdraw_money(sender_id, amount);
    EXCEPTION
      WHEN OTHERS THEN success = false;
  END;

  IF success THEN
    BEGIN
      BEGIN
        CALL sp_deposit_money(receiver_id, amount);
      EXCEPTION
        WHEN OTHERS THEN success = false;
      END;
    END;
  END IF;

  IF NOT success THEN
    ROLLBACK;
  END IF;
END;
$$;

CALL sp_transfer_money(5, 1, 5000.0000);
CALL sp_transfer_money(10, 2, 1043.9000);
CALL sp_transfer_money(13, 15, 400.9000);

SELECT 
	a."id", 
	a.account_holder_id, 
	a.balance
FROM accounts AS a
WHERE a."id" IN (5, 1);
