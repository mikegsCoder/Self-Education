CREATE TABLE logs (
  "id" SERIAL PRIMARY KEY,
  account_id INT,
  old_sum DECIMAL(19, 4),
  new_sum DECIMAL(19, 4)
);

CREATE OR REPLACE FUNCTION trigger_fn_insert_new_entry_into_logs()
RETURNS TRIGGER 
LANGUAGE plpgsql
AS $$
BEGIN
  INSERT INTO logs (
	  account_id, 
	  old_sum, 
	  new_sum
  )
  VALUES (
	  OLD."id", 
	  OLD.balance, 
	  NEW.balance
  );
  RETURN NEW;
END;
$$;
