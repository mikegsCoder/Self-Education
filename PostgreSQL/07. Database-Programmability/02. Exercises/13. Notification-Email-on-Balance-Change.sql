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

