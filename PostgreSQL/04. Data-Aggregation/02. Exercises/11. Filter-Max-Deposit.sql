SELECT 
	wd.magic_wand_creator, 
	MAX( wd.deposit_amount ) AS "Max Deposit Amount"  
FROM wizard_deposits AS wd
GROUP BY wd.magic_wand_creator
HAVING 
	MAX(
		wd.deposit_amount
	) NOT BETWEEN 30000 AND 40000
ORDER BY "Max Deposit Amount" DESC 
LIMIT 3;
