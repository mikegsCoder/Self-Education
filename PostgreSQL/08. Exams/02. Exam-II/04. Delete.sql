DELETE FROM clients AS cl
WHERE NOT EXISTS (
  SELECT 1
  FROM courses AS cou
  WHERE cou.client_id = cl."id"
)
AND LENGTH(cl.full_name) > 3
RETURNING *;
