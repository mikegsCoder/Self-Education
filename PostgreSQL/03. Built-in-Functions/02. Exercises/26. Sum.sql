SELECT SUM(	b.booked_for ) AS total_value
FROM bookings AS b
WHERE b.apartment_id = 80;
