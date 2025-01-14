SELECT "department_id",
	SUM("salary") AS "Total_Salary"
FROM "employees"
GROUP BY "department_id"
HAVING SUM("salary") < 4100
ORDER BY "department_id";
