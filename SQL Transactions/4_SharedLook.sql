USE subqueriesdb;

BEGIN TRAN ImpTR
--shared lock that is blocked with serializable
	SELECT * FROM Categories WITH (SERIALIZABLE, TABLOCK)
COMMIT

PRINT @@TRANCOUNT

SELECT * FROM Categories WITH (READUNCOMMITTED)