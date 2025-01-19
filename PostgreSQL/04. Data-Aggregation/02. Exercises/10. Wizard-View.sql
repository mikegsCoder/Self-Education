CREATE VIEW 
	view_wizard_deposits_with_expiration_date_before_1983_08_15 AS 
SELECT 
	CONCAT_WS(
		' ', 
		wd.first_name, 
		wd.last_name
	) AS "Wizard Name",
	wd.deposit_start_date AS "Start Date",
	wd.deposit_expiration_date AS "Expiration Date",
	wd.deposit_amount AS "Amount"
FROM wizard_deposits AS wd
GROUP BY 
	"Wizard Name",
	"Start Date",
	"Expiration Date",
	"Amount"
HAVING wd.deposit_expiration_date <= '1983-08-15'
ORDER BY "Expiration Date";
