CREATE TABLE search_results (
	"id" SERIAL PRIMARY KEY,
  "name" VARCHAR(50),
  release_year INT,
  rating FLOAT,
  category_name VARCHAR(50),
  publisher_name VARCHAR(50),
  min_players VARCHAR(50),
  max_players VARCHAR(50)
);
