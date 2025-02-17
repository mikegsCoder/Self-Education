CREATE OR REPLACE FUNCTION fn_is_word_comprised(
	set_of_letters VARCHAR(50), 
	word VARCHAR(50)
)
RETURNS BOOLEAN
AS $$
DECLARE 
	current_index INTEGER = 1;
	current_char CHAR;
	is_comprised BOOLEAN = FALSE;
BEGIN
	set_of_letters = LOWER(set_of_letters);
	word = LOWER(word);
	
	WHILE current_index <= LENGTH(word) LOOP
		current_char = SUBSTRING(word, current_index, 1);
		
		IF POSITION(current_char IN set_of_letters) = 0 THEN
			RETURN FALSE;
		END IF;
		
		current_index = current_index + 1;
	END LOOP;
	
	RETURN TRUE;
END;
$$ 
LANGUAGE plpgsql;

SELECT fn_is_word_comprised('ois tmiah%f', 'halves');
SELECT fn_is_word_comprised('ois tmiah%f', 'Sofia');
SELECT fn_is_word_comprised('bobr', 'Rob');
SELECT fn_is_word_comprised('papopep', 'toe');
SELECT fn_is_word_comprised('R@o!B$B', 'Bob');
SELECT fn_is_word_comprised('abcdef', 'face');
SELECT fn_is_word_comprised('12345', 'hello');
