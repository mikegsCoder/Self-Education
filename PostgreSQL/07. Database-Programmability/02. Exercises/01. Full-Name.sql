CREATE OR REPLACE FUNCTION fn_full_name(
	first_name VARCHAR(30), 
	last_name VARCHAR(50)
)
RETURNS VARCHAR 
AS $$
BEGIN
	IF first_name IS NULL AND last_name IS NULL THEN RETURN NULL;
	ELSIF first_name IS NOT NULL AND last_name IS NULL THEN	RETURN INITCAP(first_name);
	ELSIF first_name IS NULL AND last_name IS NOT NULL THEN	RETURN INITCAP(last_name);
	ELSE RETURN INITCAP(CONCAT_WS(' ', first_name, last_name));
	END IF;
END;
$$ 
LANGUAGE plpgsql;

SELECT fn_full_name('fred', 'sanford') AS "Full Name";
SELECT fn_full_name('', 'SIMPSONS') AS "Full Name";
SELECT fn_full_name('JOHN', '') AS "Full Name";
SELECT fn_full_name(NULL, NULL) AS "Full Name";
SELECT fn_full_name('JANE', 'smith') AS "Full Name";
SELECT fn_full_name('John', 'Doe') AS "Full Name";
