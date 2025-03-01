SELECT 
	v."name" AS "Volunteers Name", 
	v.phone_number AS "Phone Number",
	SUBSTRING(
		v.address, POSITION('Sofia' IN v.address) + 7
	) AS "Address"
FROM volunteers AS v
JOIN volunteers_departments AS vd 
	ON v.department_id = vd."id"
WHERE vd.department_name = 'Education program assistant'
	AND v.address LIKE '%Sofia%'
ORDER BY v."name";
