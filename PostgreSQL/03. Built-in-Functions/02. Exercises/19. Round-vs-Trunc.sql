SELECT a.latitude,
  ROUND( a.latitude, 2	),
	TRUNC( a.latitude, 2	)
FROM apartments AS a;
