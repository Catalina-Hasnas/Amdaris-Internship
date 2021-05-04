BEGIN TRAN

UPDATE dbo.Customers
  SET Customers.MonthlyDiscount += 10
FROM dbo.Customers AS C 
  INNER JOIN dbo.Packages AS P
    ON C.PackageId = P.Id
WHERE C.State = 'Michigan';

SELECT * FROM dbo.Customers

ROLLBACK