CREATE VIEW view_river_info AS 
SELECT CONCAT(
	'The river',
	' ',
	r.river_name,
	' ',
	'flows into the',
	' ',  
	r.outflow,
	' ',
	'and is',
	' ',
	r."length",
	' ',
	'kilometers long'
	) AS "River information"
FROM rivers AS r
ORDER BY r.river_name;
