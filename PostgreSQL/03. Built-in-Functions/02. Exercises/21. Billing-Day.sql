ALTER TABLE bookings
ADD COLUMN billing_day TIMESTAMPTZ NOT NULL DEFAULT CURRENT_TIMESTAMP;

SELECT 
	TO_CHAR(
	b.billing_day, 
	'DD "Day" MM "Month" YYYY "Year" HH24:MI:SS'
	) AS "Billing Day"
FROM bookings AS b;
