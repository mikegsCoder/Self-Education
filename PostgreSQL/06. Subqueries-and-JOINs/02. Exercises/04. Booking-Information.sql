SELECT 
	b.booking_id AS "Booking ID",
	a."name" AS "Apartment Owner",
	a.apartment_id AS "Apartment ID",
	CONCAT_WS(' ', c.first_name, c.last_name) AS "Customer Name"
FROM apartments AS a
FULL OUTER JOIN bookings AS b
	ON a.booking_id = b.booking_id
FULL OUTER JOIN customers AS c
	ON b.customer_id = c.customer_id
ORDER BY "Booking ID", "Apartment Owner",	"Customer Name";
