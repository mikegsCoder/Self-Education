SELECT 
	CONCAT_WS(' ', a.address, a.address_2) AS "Apartment Address",
	b.booked_for AS "Nights"
FROM 	apartments AS a
INNER JOIN bookings AS b
	ON a.booking_id = b.booking_id
ORDER BY a.apartment_id;
