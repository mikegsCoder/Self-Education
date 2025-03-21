CREATE TABLE notification_emails (
  "id" SERIAL PRIMARY KEY,
  recipent_id INT,
  subject VARCHAR(50),
  body TEXT
);

CREATE OR REPLACE FUNCTION trigger_fn_send_email_on_balance_change()
RETURNS TRIGGER 
LANGUAGE plpgsql
AS $$
BEGIN
  INSERT INTO notification_emails (
	recipent_id,
    subject,
    body
  )
  VALUES (
	NEW.account_id,
    CONCAT(
		'Balance change for account: ', NEW.account_id
	),
    CONCAT(
		'On ', CURRENT_DATE, ' your balance was changed from ', OLD.old_sum, ' to ', NEW.new_sum, '.'
	)
  );
  RETURN NEW;
END;
$$;

CREATE OR REPLACE TRIGGER tr_send_email_on_balance_change
	AFTER UPDATE ON logs
	FOR EACH ROW
	EXECUTE FUNCTION trigger_fn_send_email_on_balance_change();

UPDATE logs
SET new_sum = new_sum + 100
WHERE account_id = 1;

SELECT * FROM notification_emails;
