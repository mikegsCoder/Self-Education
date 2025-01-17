SELECT 
	wd.deposit_group,
	SUM( wd.deposit_interest ) AS "Deposit_Interest"
FROM wizard_deposits AS wd
GROUP BY wd.deposit_group
ORDER BY "Deposit_Interest" DESC;
