-- Delete records from referencing tables
DELETE FROM volunteers
WHERE department_id = 3;

-- Delete records from volunteers_departments table
DELETE FROM volunteers_departments
WHERE "id" = 3
RETURNING *;
