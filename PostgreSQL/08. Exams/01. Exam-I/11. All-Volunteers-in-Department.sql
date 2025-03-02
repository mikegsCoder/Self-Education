CREATE OR REPLACE FUNCTION fn_get_volunteers_count_from_department(
  searched_volunteers_department VARCHAR(30)
)
RETURNS INT
AS $$
DECLARE 
  count_value INT;
BEGIN
  SELECT COUNT(v.id)
  INTO count_value
  FROM volunteers AS v
  JOIN volunteers_departments AS vd
  	ON v.department_id = vd."id"
  WHERE vd.department_name = searched_volunteers_department;
  
  RETURN count_value;
END;
$$
LANGUAGE plpgsql;

SELECT fn_get_volunteers_count_from_department('Education program assistant');
SELECT fn_get_volunteers_count_from_department('Guest engagement');
SELECT fn_get_volunteers_count_from_department('Zoo events');
