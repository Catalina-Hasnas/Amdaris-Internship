select  
    object_name(p.object_id) as TableName, 
    resource_type, resource_description
from
    sys.dm_tran_locks l
    join sys.partitions p on l.resource_associated_entity_id = p.hobt_id


USE subqueriesdb;

BEGIN TRAN t2

	SELECT * FROM Categories
	--exclusive lock
	INSERT INTO [Categories]
           ([Id]
		   ,[Name])
     VALUES
           (99, 'Coffee99')
ROLLBACK

PRINT @@TRANCOUNT