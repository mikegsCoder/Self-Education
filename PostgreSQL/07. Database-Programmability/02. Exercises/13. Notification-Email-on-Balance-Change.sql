CREATE TABLE notification_emails (
  "id" SERIAL PRIMARY KEY,
  recipent_id INT,
  subject VARCHAR(50),
  body TEXT
);
