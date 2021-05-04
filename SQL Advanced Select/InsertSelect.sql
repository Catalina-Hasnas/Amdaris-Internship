BEGIN TRAN
CREATE TABLE [dbo].[TexasCustomers]
(
    Id		BIGINT        NOT NULL IDENTITY(1,1) CONSTRAINT [PK_TexasCustomers] PRIMARY KEY CLUSTERED,
    [Name]	NVARCHAR (50) NOT NULL,
    [State] NVARCHAR (50) NOT NULL,
    [City]	NVARCHAR (50) NOT NULL,
    [Fax]	NVARCHAR (50),
	[MonthlyDiscount] BIGINT NOT NULL,
	[PackageId] BIGINT NOT NULL

) ON [PRIMARY];
GO

SET IDENTITY_INSERT [dbo].[TexasCustomers] ON;
INSERT INTO [dbo].[TexasCustomers] (Id, Name, State, City, Fax, MonthlyDiscount, PackageId)
SELECT Id, Name, State, City, Fax, MonthlyDiscount, PackageId
FROM   [dbo].[Customers]
WHERE  State = 'Texas';

SET IDENTITY_INSERT [dbo].[TexasCustomers] OFF;

GO

SELECT * FROM [dbo].[TexasCustomers]

COMMIT

ROLLBACK

