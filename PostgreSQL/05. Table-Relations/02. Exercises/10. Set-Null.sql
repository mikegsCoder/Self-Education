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
