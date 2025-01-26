/* create table */
CREATE TABLE IF NOT EXISTS products (
  product_name VARCHAR(100) NOT NULL
);

INSERT INTO products (product_name) 
VALUES
	('Broccoli'),
	('Shampoo'),
	('Toothpaste'),
	('Candy');
	
/* define primary key */
ALTER TABLE products
ADD COLUMN "id" SERIAL PRIMARY KEY;
