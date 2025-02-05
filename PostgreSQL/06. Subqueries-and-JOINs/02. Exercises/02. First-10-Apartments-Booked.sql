SELECT 
	a."name" AS "Name",
	a.country AS "Country",
	b.booked_at::date AS "Booked at"
FROM apartments AS a
LEFT JOIN bookings AS b
	ON a.booking_id = b.booking_id
LIMIT 10;
