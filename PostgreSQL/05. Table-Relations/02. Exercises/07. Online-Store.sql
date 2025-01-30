/* cities table */
CREATE TABLE IF NOT EXISTS cities (
  "id" SERIAL PRIMARY KEY,
  city_name VARCHAR(50)
);

/* customers table */
CREATE TABLE IF NOT EXISTS customers (
  "id" SERIAL PRIMARY KEY,
  customer_name VARCHAR(50),
	birthday DATE,
	city_id INT,
	CONSTRAINT fk_customers_cities
		FOREIGN KEY (city_id) 
		REFERENCES cities("id")
);

/* orders table */
CREATE TABLE IF NOT EXISTS orders (
  "id" SERIAL PRIMARY KEY,
	customer_id INT,
	CONSTRAINT fk_orders_customers
		FOREIGN KEY (customer_id) 
		REFERENCES customers("id")
);

/* item types table */
CREATE TABLE IF NOT EXISTS item_types (
  "id" SERIAL PRIMARY KEY,
  item_type_name VARCHAR(50)
);
