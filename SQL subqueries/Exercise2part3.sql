USE subqueriesdb;

-- creates a column "PriceReview" with a custom string depending on the product price

SELECT p.Name, p.Price,
CASE 
	WHEN p.Price >= 500 THEN 'The price is waaay too high'
	WHEN p.Price <= 10 THEN 'The quantity is waaay too low'
	ELSE 'The price is good'
END AS PriceReview
FROM Products as p;

-- tried to do an example as the previous one, but with an "alias" variable in the case statement
-- creates a table categorySts with a custom string depending on the number of products in each category

SELECT * ,
CASE
    WHEN nrProd = 0 THEN 'empty'
    WHEN nrProd <= 4 THEN 'good'
    WHEN nrProd >= 5 THEN 'full'
    ELSE 'some error'
	-- todo: implement with inner join instead of a select subquery
END as categoryStatus FROM (
	SELECT c.Name, 
		(SELECT COUNT(p.Id)
		FROM Products as p
		WHERE c.Id = p.CategoryId) as nrProd
	FROM Categories as c
) as categorySts

