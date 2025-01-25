CREATE TABLE mountains(
  id SERIAL PRIMARY KEY,
  name VARCHAR(20) NOT NULL
);

CREATE TABLE peaks(
  id SERIAL PRIMARY KEY,
  name VARCHAR(20) NOT NULL,
  mountain_id INT,
  CONSTRAINT fk_mountain_id 
  FOREIGN KEY(mountain_id)
  REFERENCES mountains(id)
  ON DELETE CASCADE
);
