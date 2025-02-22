CREATE TABLE logs (
  "id" SERIAL PRIMARY KEY,
  account_id INT,
  old_sum DECIMAL(19, 4),
  new_sum DECIMAL(19, 4)
);
