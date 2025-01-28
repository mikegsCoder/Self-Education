/* create tables */
CREATE TABLE IF NOT EXISTS customers (
  "id" SERIAL PRIMARY KEY,
  name VARCHAR(50),
	date DATE NOT NULL
);

CREATE TABLE IF NOT EXISTS photos (
  "id" SERIAL PRIMARY KEY,
	url TEXT,
	place VARCHAR(80),
	customer_id INT,
	CONSTRAINT fk_photos_customers
		FOREIGN KEY (customer_id) 
		REFERENCES customers("id")
);
