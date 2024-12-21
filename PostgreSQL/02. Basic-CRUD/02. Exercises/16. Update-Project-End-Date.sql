UPDATE projects
SET end_date = start_date + INTERVAL '3 months'
WHERE end_date IS NULL;
