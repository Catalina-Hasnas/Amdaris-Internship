USE subqueriesdb;

-- type of the transaction: EXPLICIT

BEGIN TRAN  
	-- will print 1, because we've started a transaction
    PRINT @@TRANCOUNT  
    BEGIN TRAN  
		-- will print 2, because we've started a nested transaction
        PRINT @@TRANCOUNT  
    COMMIT  
	-- will print 1, because we've commited the nested transaction
    PRINT @@TRANCOUNT  
COMMIT  
-- will print 0, because we've commited the remaining transaction
PRINT @@TRANCOUNT 