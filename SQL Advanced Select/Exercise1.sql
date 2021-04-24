USE dbo;


IF OBJECT_ID('dbo.Customers', 'U') IS NOT NULL 
  DROP TABLE dbo.Customers;
GO

IF OBJECT_ID('dbo.Packages', 'U') IS NOT NULL 
  DROP TABLE dbo.Packages;
GO

CREATE TABLE [dbo].[Customers]
(
    Id		BIGINT        NOT NULL IDENTITY(1,1) CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED,
    [Name]	NVARCHAR (50) NOT NULL,
    [State] NVARCHAR (50) NOT NULL,
    [City]	NVARCHAR (50) NOT NULL,
    [Fax]	NVARCHAR (50),
	[MonthlyDiscount] BIGINT NOT NULL,
	[PackageId] BIGINT NOT NULL

) ON [PRIMARY];
GO

CREATE TABLE [dbo].[Packages]
(
    Id					BIGINT          NOT NULL CONSTRAINT [PK_Packages] PRIMARY KEY CLUSTERED,
    [MonthlyPayment]	BIGINT			NOT NULL,
    [InternetSpeed]		BIGINT          NOT NULL,
    [SectorNumber]		BIGINT          NOT NULL
) ON [PRIMARY];
GO

ALTER TABLE [Customers]
    ADD CONSTRAINT Customer_PackageId FOREIGN KEY (PackageId) REFERENCES Packages (Id) ON DELETE NO ACTION ON UPDATE NO ACTION;

	USE [dbo]
GO

USE [dbo]
GO

INSERT INTO [dbo].[Packages]
           ([Id]
		   ,[MonthlyPayment]
           ,[InternetSpeed]
           ,[SectorNumber])
     VALUES
           (1, 50, 15, 1),
           (2, 100, 25, 1),
           (3, 175, 25, 2),
           (4, 200, 50, 2),
           (5, 210, 100, 3),
           (6, 250, 150, 3),
           (7, 300, 200, 3),
           (8, 500, 500, 4)
GO



INSERT INTO [dbo].[Customers]
           ([Name]
           ,[State]
           ,[City]
           ,[Fax]
           ,[MonthlyDiscount]
           ,[PackageId])
     VALUES
           ('Rosemary Everson', 'Michigan', 'Westland', '517-673-1204', 10, 1),
           ('Danielle Davidson', 'Florida', 'Jacksonville', '904-753-4462', 5, 3),
           ('Angel Battle', 'Arizona', 'Phoenix', '928-504-1235', 20, 4),
           ('Steven Friend', 'Texas', 'FREDONIA', '606-855-0428', 0, 2),
           ('Virginia Miller', 'Michigan', 'Westland', '260-482-5353', 40, 1),
           ('Daisy Thompson', 'Texas', 'El Paso', NULL, 0, 3),
           ('Keisha Catron', 'Minnesota', 'Detroit Lakes', '218-844-6067', 30, 2),
           ('Esther Smith', 'Louisiana', 'Kenner', NULL, 25, 4),
           ('David Goodman', 'California', 'DOWNIEVILLE', '951-733-7716', 0, 5)
GO

