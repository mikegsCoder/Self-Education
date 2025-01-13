SELECT "department_id", 
  SUM("salary") AS "Total_Salaries"
FROM "employees"
GROUP BY "department_id"
ORDER BY "department_id";
