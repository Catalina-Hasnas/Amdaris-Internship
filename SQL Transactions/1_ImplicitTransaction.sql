USE subqueriesdb;

-- type of the transaction: IMPLICIT

SET IMPLICIT_TRANSACTIONS ON
-- updates a row in Products table and creates a transaction automatically
UPDATE Products
SET Name = 'Costa Rican Dark Roast Coffee test'
WHERE Id = 1;

-- we can't read the Products table if transaction is not finished
-- either rollback or commit

ROLLBACK
COMMIT

SET IMPLICIT_TRANSACTIONS OFF

SELECT * FROM Products;
PRINT @@TRANCOUNT


