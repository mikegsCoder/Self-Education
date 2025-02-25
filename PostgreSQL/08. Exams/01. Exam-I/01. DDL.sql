CREATE TABLE IF NOT EXISTS owners (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50) NOT NULL,
  phone_number VARCHAR(15) NOT NULL,
  address VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS animal_types (
  "id" SERIAL PRIMARY KEY,
  animal_type VARCHAR(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS cages (
  "id" SERIAL PRIMARY KEY,
  animal_type_id INT NOT NULL,
  CONSTRAINT fk_cages_animal_type_id
	FOREIGN KEY (animal_type_id) 
	REFERENCES animal_types("id")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS animals (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(30) NOT NULL,
  birthdate DATE NOT NULL,
  owner_id INT,
  animal_type_id INT NOT NULL,
  CONSTRAINT fk_animals_owner_id
	FOREIGN KEY (owner_id) 
	REFERENCES owners("id")
	ON DELETE CASCADE
	ON UPDATE CASCADE,
  CONSTRAINT fk_cages_animal_type_id
	FOREIGN KEY (animal_type_id) 
	REFERENCES animal_types("id")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS volunteers_departments (
  "id" SERIAL PRIMARY KEY,
  department_name VARCHAR(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS volunteers (
  "id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50) NOT NULL,
  phone_number VARCHAR(15) NOT NULL,
  address VARCHAR(50),
  animal_id INT,
  department_id INT NOT NULL,
  CONSTRAINT fk_volunteers_animal_id
	FOREIGN KEY (animal_id) 
	REFERENCES animals("id")
	ON DELETE CASCADE
	ON UPDATE CASCADE,
  CONSTRAINT fk_volunteers_department_id
	FOREIGN KEY (department_id) 
	REFERENCES volunteers_departments("id")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
