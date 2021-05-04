use dbo

--sets the customer's monthly payment, 
--based on the monthly payment of the package minus the customer's discount
--if the customer doesn't have a package id, his monthly payment is set to 0

BEGIN TRAN

MERGE INTO dbo.Customers AS C
USING (SELECT   P.Id,
                P.MonthlyPayment
       FROM     dbo.Packages AS P) AS P
       ON P.Id = C.PackageId

WHEN MATCHED THEN UPDATE 
    SET C.MonthlyPayment = P.MonthlyPayment - C.MonthlyDiscount

WHEN NOT MATCHED BY SOURCE THEN UPDATE 
    SET C.MonthlyPayment = 0;

SELECT * FROM Customers

ROLLBACK