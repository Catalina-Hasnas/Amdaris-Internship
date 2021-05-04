BEGIN TRAN

DELETE dbo.Customers
FROM   dbo.Customers AS C
       INNER JOIN
       dbo.Packages AS P
       ON C.PackageId = P.Id
WHERE  C.State = 'Texas';

SELECT * FROM dbo.Customers

ROLLBACK