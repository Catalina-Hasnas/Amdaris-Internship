USE subqueriesdb;

-- for products that have a price that is above average the average product price, selects name and price

SELECT p.Name, p.Price
FROM Products as p
WHERE p.Price > ( 
	SELECT AVG(p2.Price)
	FROM Products as p2
);


-- for the categories that have the sum of products prices bigger than those of category 2,
-- selects category id and the sum of the products' prices in those categories;

SELECT p.CategoryId, SUM(p.Price)
FROM Products as p
GROUP BY CategoryId
HAVING SUM(p.price) > ( 
	SELECT SUM(p2.Price)
	FROM Products as p2
	WHERE (p2.CategoryId = 2)
);

-- selects all category names, the number of products in them and the average product price of the products in them

SELECT c.Name,

	(SELECT COUNT(p.Id)
	FROM Products as p
	WHERE c.Id = p.CategoryId) as nrProd,

	(SELECT AVG(p2.Price)
	FROM Products as p2
	WHERE c.Id = p2.CategoryId) as avgPrice

FROM Categories as c





