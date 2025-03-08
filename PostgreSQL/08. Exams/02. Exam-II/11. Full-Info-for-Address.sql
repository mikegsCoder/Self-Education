CREATE TABLE search_results (
  id SERIAL PRIMARY KEY,
  address_name VARCHAR(50),
  full_name VARCHAR(100),
  level_of_bill VARCHAR(20),
  make VARCHAR(30),
  condition CHAR(1),
  category_name VARCHAR(50)
);

