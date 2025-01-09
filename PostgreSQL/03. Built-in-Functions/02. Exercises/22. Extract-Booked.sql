SELECT 
  EXTRACT( YEAR FROM b.booked_at ) AS "YEAR",
  EXTRACT( MONTH FROM b.booked_at	) AS "MONTH",
  EXTRACT( DAY FROM b.booked_at	) AS "DAY",
  EXTRACT( HOUR FROM b.booked_at AT TIME ZONE 'UTC'	) AS "HOUR",
  EXTRACT( MINUTE FROM b.booked_at ) AS "MINUTE",
  CEILING( EXTRACT( SECOND FROM b.booked_at	)) AS "SECOND"
FROM bookings AS b;
