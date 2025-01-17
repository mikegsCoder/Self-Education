SELECT 
	wd.magic_wand_creator,
	MIN( wd.magic_wand_size	) AS "Minimum_Wand_Size"
FROM wizard_deposits AS wd
GROUP BY wd.magic_wand_creator
ORDER BY "Minimum_Wand_Size"
LIMIT 6;
