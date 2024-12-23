CREATE VIEW view_addresses AS 
SELECT 
	e.first_name || ' ' || e.last_name AS "Full Name",
	e.department_id,
	a."number" || ' ' || a.street AS "Address"
FROM 
	employees AS e, 
	addresses AS a
WHERE e.address_id = a."id"
ORDER BY "Address";
