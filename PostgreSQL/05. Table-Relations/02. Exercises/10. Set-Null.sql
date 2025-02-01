/* create customers table */
CREATE TABLE customers(
  "id" SERIAL PRIMARY KEY,
  customer_name VARCHAR(100) NOT NULL
);

/* create contacts table */
CREATE TABLE contacts(
  "id" SERIAL PRIMARY KEY,
  contact_name VARCHAR(255) NOT NULL,
  phone VARCHAR(15),
  email VARCHAR(255),
  customer_id INT,
  CONSTRAINT fk_contacts_customers
    FOREIGN KEY(customer_id) 
	  REFERENCES customers("id")
	  ON DELETE SET NULL
	  ON UPDATE CASCADE
);

/* insert into customers table */
INSERT INTO customers (customer_name) 
VALUES
	('BlueBird Inc'),
	('Dolphin LLC');
	
/* insert into contacts table */
INSERT INTO contacts (customer_id, contact_name, phone, email) 
VALUES
	(1,'John Doe','(408)-111-1234','john.doe@bluebird.dev'),
  (1,'Jane Doe','(408)-111-1235','jane.doe@bluebird.dev'),
  (2,'David Wright','(408)-222-1234','david.wright@dolphin.dev');

/* delete customer with "id" = 1 */ 
DELETE FROM customers
WHERE customers.id = 1;
