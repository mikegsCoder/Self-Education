SELECT 
  "department_id",
  MIN("salary") AS "Min_Salary"
FROM "employees"
GROUP BY "department_id"
ORDER BY "department_id";
