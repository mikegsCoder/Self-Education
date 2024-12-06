CREATE TABLE employees (	
  id SERIAL PRIMARY KEY NOT NULL,
  first_name VARCHAR (20),
  last_name VARCHAR (20),
  hiring_date DATE DEFAULT '2024-01-01',
  salary NUMERIC(10, 2),
  devices_number INT 
);

CREATE TABLE departments (	
  id SERIAL PRIMARY KEY NOT NULL,
  name VARCHAR (20),
  code CHAR (3),
  description TEXT
);

CREATE TABLE issues (
  id SERIAL NOT NULL UNIQUE,
  description VARCHAR(130),
  "date" DATE,
  "start" TIMESTAMP
);