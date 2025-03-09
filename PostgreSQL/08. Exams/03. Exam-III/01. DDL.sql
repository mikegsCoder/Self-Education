CREATE TABLE IF NOT EXISTS categories (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS addresses (
  "id" SERIAL PRIMARY KEY,
  street_name VARCHAR(100) NOT NULL,
  street_number INT NOT NULL,
  town VARCHAR(30) NOT NULL,
  country VARCHAR(50) NOT NULL,
  zip_code INT NOT NULL,
  CONSTRAINT addresses_street_number_check CHECK (street_number > 0),
  CONSTRAINT addresses_zip_code_check CHECK (zip_code > 0)
);

CREATE TABLE IF NOT EXISTS publishers (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(30) NOT NULL,
  address_id INT NOT NULL,
  website VARCHAR(40),
  phone VARCHAR(20),
  CONSTRAINT fk_publishers_address_id
	FOREIGN KEY (address_id) 
	REFERENCES addresses("id")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
