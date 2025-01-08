CREATE TABLE bookings_calculation 
AS SELECT	b.booked_for
FROM bookings AS b
WHERE b.apartment_id = 91;

ALTER TABLE bookings_calculation
ADD COLUMN multiplication NUMERIC,
ADD COLUMN modulo NUMERIC;

UPDATE bookings_calculation
SET 
	multiplication = booked_for * 40,
	modulo = booked_for % 40;
