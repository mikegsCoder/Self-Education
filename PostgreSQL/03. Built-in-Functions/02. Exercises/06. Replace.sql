SELECT
	REPLACE(m.mountain_range,	'a', '@') AS "replace_a",
	REPLACE(m.mountain_range,	'A', '$') AS "replace_A"
FROM mountains AS m;
