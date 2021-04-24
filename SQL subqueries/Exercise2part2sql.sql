USE subqueriesdb;

-- selects all categories that have products

SELECT c.Name
FROM Categories as c
WHERE EXISTS (
	SELECT p.Id
	FROM Products as p
	WHERE p.CategoryId = c.Id
);

-- selects products that are in top 3 most expensive categories

SELECT p.Name
FROM Products as p
Where p.CategoryId IN (
	SELECT TOP 3 p2.CategoryId
	FROM Products as p2
	GROUP BY p2.CategoryId
	ORDER BY (SUM(p2.Price)) DESC
);

-- selects products that are more expensive than at least one product from category with id = 1

SELECT p.Name, p.Price
FROM Products as p
WHERE p.Price > ANY ( 
	SELECT p2.Price
	FROM Products as p2
	WHERE (p2.CategoryId = 1)
);

-- selects the products that are the cheapest in their category

SELECT p.Name, p.Price, p.CategoryId 
FROM Products as p
WHERE p.Price <= ALL (
	SELECT p2.Price
	FROM Products as p2
	WHERE p2.CategoryId = p.CategoryId
);

