CREATE PROCEDURE sp_increase_salaries(department_name varchar(50))
LANGUAGE plpgsql
AS $$
BEGIN
UPDATE employees AS e
SET salary = salary * 1.05
WHERE e.department_id = (
SELECT department_id FROM departments WHERE name = department_name);
END; 

$$;
