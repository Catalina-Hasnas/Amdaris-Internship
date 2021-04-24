USE subqueriesdb;

IF OBJECT_ID('dbo.Products', 'U') IS NOT NULL 
  DROP TABLE dbo.Products;
GO

IF OBJECT_ID('dbo.Categories', 'U') IS NOT NULL 
  DROP TABLE dbo.Categories;
GO

CREATE TABLE [dbo].[Products]
(
    Id				BIGINT			NOT NULL IDENTITY(1,1) CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED,
    [Name]			NVARCHAR(50)	NOT NULL,
	[Price]			BIGINT			NOT NULL,
	[CategoryId]	BIGINT			NOT NULL

) ON [PRIMARY];
GO

CREATE TABLE [dbo].[Categories]
(
    Id			BIGINT          NOT NULL CONSTRAINT [PK_Packages] PRIMARY KEY CLUSTERED,
    [Name]		NVARCHAR (50)	NOT NULL
) ON [PRIMARY];
GO

ALTER TABLE [Products]
    ADD CONSTRAINT Products_CategoryId FOREIGN KEY (CategoryId) REFERENCES Categories (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

INSERT INTO [Categories]
           ([Id]
		   ,[Name])
     VALUES
           (1, 'Coffee'),
           (2, 'Tea'),
           (3, 'Milk'),
           (4, 'Coffee Machines'),
           (5, 'Sweeteners')
GO

SET IDENTITY_INSERT Products ON;  
INSERT INTO [Products]
           ([Id]
		   ,[Name]
           ,[Price]
           ,[CategoryId])
     VALUES
           (1, 'Costa Rican Dark Roast Coffee', 13, 1),
           (2, 'Costa Rican Tarrazu Montecielo Coffee', 14, 1),
           (3, 'Costa Rican Organic Coffee', 15, 1),
           (4, 'Costa Rican Tres Rios Valdivia Coffee', 14, 1),
           (5, 'Costa Rican Poas Tierra Volcanica Coffee', 14, 1),
           (6, 'Britt Decaf Espresso Coffee Capsules', 19, 1),
           (7, 'Costa Rican Fusion Coffee', 13, 1),
           (8, 'Costa Rican Habitat Jaguar Coffee', 16, 1),
		   (9, 'Rose Black Tea', 19, 2),
           (10, 'Wellness Gut Health Tea', 29, 2),
           (11, 'Wellness Mood Boosting Tea', 34, 2),
           (12, 'Chaga Chai Mushroom Tea', 29, 2),
		   (13, 'Whole milk', 10, 3),
		   (14, 'Almond Milk', 15, 3),
		   (15, 'Soy Milk', 13, 3),
		   (16, 'Autentica ETAM ETAM29.620.SB ', 550, 4),
           (17, 'PrimaDonna Class ECAM550.75.MS', 410, 4),
		   (18, 'PrimaDonna XS ETAM 36.365.MB ', 320, 4),
		   (19, 'Maestosa EPAM960.75.GLM ', 650, 4),
		   (20, 'PrimaDonna Elite Experience ECAM650.85.MS', 280, 4),
		   (21, 'Sugar', 5, 5),
		   (22, 'Stevia', 9, 5),
		   (23, 'Honey', 8, 5)
GO
SET IDENTITY_INSERT Products OFF;

SELECT * FROM Categories
SELECT * FROM Products