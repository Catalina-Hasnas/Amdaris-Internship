USE subqueriesdb;

BEGIN TRAN t1

	UPDATE Categories
	SET Name = 'Cofee UPDATED IN T1'
	WHERE Id = 1;

	UPDATE Products
	SET Name = 'Costa Rican Dark Roast Coffee UPDATED IN T1'
	WHERE Id = 1;

ROLLBACK

PRINT @@TRANCOUNT