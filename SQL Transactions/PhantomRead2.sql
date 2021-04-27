USE subqueriesdb;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

BEGIN TRAN t6

	UPDATE Categories
	SET Name = 'Cofee IS IN DIRTY READ'
	WHERE Id = 1;


	INSERT INTO [dbo].[Categories]
           ([Id]
           ,[Name])
    VALUES
        (666,'Phantom Coffee')

COMMIT
ROLLBACK


PRINT @@TRANCOUNT