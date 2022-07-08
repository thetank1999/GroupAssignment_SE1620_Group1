CREATE TABLE [dbo].[Category](
	[CategoryId] INT IDENTITY(1,1) PRIMARY KEY,
	[CategoryName] varchar(512) NOT NULL,
	[CategoryStatus] BIT NOT NULL DEFAULT 1,
)