USE subqueriesdb;

BEGIN TRAN t2

	UPDATE Products
	SET Name = 'Costa Rican Dark Roast Coffee UPDATED IN T2'
	WHERE Id = 1;
	
	UPDATE Categories
	SET Name = 'Cofee UPDATED IN T2'
	WHERE Id = 1;

ROLLBACK

PRINT @@TRANCOUNT

--dirty read
select * from Categories with (READUNCOMMITTED)
select * from Products with (READUNCOMMITTED)

SELECT * from Products with (READUNCOMMITTED)
INNER JOIN Categories with (READUNCOMMITTED) on Categories.Id = Products.CategoryId


