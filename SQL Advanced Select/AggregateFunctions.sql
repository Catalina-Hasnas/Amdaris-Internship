USE dbo;

SELECT TOP 1
	c.Name
FROM Customers as c
ORDER BY c.Name DESC
GO

SELECT AVG(p.MonthlyPayment) as Average_Payment
FROM Packages as p
GO

SELECT TOP 1
	c.Name
FROM Customers as c
ORDER BY c.Name ASC
GO

SELECT COUNT(p.MonthlyPayment) as Number_Packages
FROM Packages as p
GO

SELECT COUNT(c.Id) as Number_Customers
FROM Customers as c
GO

SELECT COUNT ( DISTINCT c.State ) AS "Number of states" 
FROM Customers as c;

SELECT COUNT ( DISTINCT p.InternetSpeed ) AS "Number of states" 
FROM Packages as p

SELECT COUNT(CASE WHEN c.Fax IS NOT NULL AND c.Fax != '' THEN 1 END) as "Nr Of fax"
FROM Customers as c

SELECT COUNT(CASE WHEN c.Fax IS NULL THEN 1 END) as "Nr Of NULL fax"
FROM Customers as c

SELECT MAX(c.MonthlyDiscount) as "Max Discount",
	MIN(c.MonthlyDiscount) as "Min Discount",
	AVG(c.MonthlyDiscount) as "Avg Discount"
FROM Customers as c