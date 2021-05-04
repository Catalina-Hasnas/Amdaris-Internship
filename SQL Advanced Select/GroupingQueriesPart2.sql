USE dbo;

SELECT c.State, COUNT(c.Id) as "Nr of customers"
FROM Customers as c
GROUP BY c.State


SELECT p.InternetSpeed, AVG(p.MonthlyPayment) as "Average price"
FROM Packages as p
GROUP BY p.InternetSpeed

SELECT c.State, COUNT(DISTINCT c.City) as "Distinct cites"
FROM Customers as c
GROUP BY c.State

SELECT p.SectorNumber, MAX(p.MonthlyPayment) as "High price"
FROM Packages as p
GROUP BY p.SectorNUmber

SELECT c.PackageId as "Package Number", AVG(c.MonthlyDiscount) as "Avg discount"
FROM Customers as c
GROUP BY c.PackageId

SELECT c.PackageId as "Package Number", AVG(c.MonthlyDiscount) as "Avg discount"
FROM Customers as c
WHERE c.PackageId = 1 OR c.PackageId = 2
GROUP BY c.PackageId

SELECT p.InternetSpeed,
	MAX(p.MonthlyPayment) as "Max Payment",
	MIN(p.MonthlyPayment) as "Min Payment",
	AVG(p.MonthlyPayment) as "Avg Payment"
FROM Packages as p
GROUP BY p.InternetSpeed

SELECT c.PackageId as "InternetPackage",
	COUNT(c.Id) as "Number of customers"
FROM Customers as c
GROUP BY c.PackageId


SELECT c.PackageId as "InternetPackage",
	COUNT(c.Id) as "Number of customers"
FROM Customers as c
WHERE c.MonthlyDiscount > 20
GROUP BY c.PackageId

SELECT c.PackageId as "InternetPackage",
	COUNT(c.Id) as "Number of customers"
FROM Customers as c
GROUP BY c.PackageId
HAVING COUNT(c.Id) > 1

SELECT c.State,
	c.City,
	COUNT(c.Id) as "Nr customers"
FROM Customers as c
GROUP BY c.State, c.City

SELECT c.City,
	AVG(c.MonthlyDiscount) as "Avg discount"
FROM Customers as c
GROUP BY c.City

SELECT c.City,
	AVG(c.MonthlyDiscount) as "Avg discount"
FROM Customers as c
WHERE c.MonthlyDiscount > 20
GROUP BY c.City

SELECT c.State, 
	MIN(c.MonthlyDiscount) as "Min Discount"
FROM Customers as c
GROUP BY c.State

SELECT c.State,
	MIN(c.MonthlyDiscount) as "Min discount"
FROM Customers as c
GROUP BY c.State
HAVING MIN(c.MonthlyDiscount) > 10

SELECT p.InternetSpeed, Count(p.Id) as "Nr packages"
FROM Packages as p
GROUP BY p.InternetSpeed
HAVING COUNT(p.Id) > 1
