/* students table */
CREATE TABLE IF NOT EXISTS students (
  "id" SERIAL PRIMARY KEY,
  student_name VARCHAR(50)
);

INSERT INTO students (student_name) 
VALUES
	('Mila'),
	('Toni'),
	('Ron');
