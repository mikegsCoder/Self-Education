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

/* items table */
CREATE TABLE IF NOT EXISTS items (
  "id" SERIAL PRIMARY KEY,
  item_name VARCHAR(50),
	item_type_id INT,
	CONSTRAINT fk_items_item_types
		FOREIGN KEY (item_type_id) 
		REFERENCES item_types("id")
);

/* order items table */
CREATE TABLE IF NOT EXISTS order_items (
  order_id INT,
  item_id INT,
 	CONSTRAINT pk_order_items
		PRIMARY KEY(order_id, item_id),
	CONSTRAINT fk_order_items_orders
		FOREIGN KEY(order_id)
		REFERENCES orders("id"),
	CONSTRAINT fk_order_items_items
		FOREIGN KEY(item_id)
		REFERENCES items("id")
);
