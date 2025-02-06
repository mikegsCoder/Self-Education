SELECT 
	b.booking_id AS "Booking ID",
	c.first_name AS "Customer Name"
FROM bookings AS b
CROSS JOIN customers AS c
ORDER BY "Customer Name";
