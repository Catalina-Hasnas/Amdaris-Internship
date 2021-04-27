USE subqueriesdb;

-- type of the transaction: AUTOCOMMIT

SET IMPLICIT_TRANSACTIONS OFF
-- this is an autocommit to test reading a product while the transaction is not finished

SELECT * FROM Products;