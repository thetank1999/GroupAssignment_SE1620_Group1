CREATE TABLE [dbo].[Category](
	[CategoryId] INT IDENTITY(1,1) PRIMARY KEY,
	[CategoryName] TEXT NOT NULL,
	[CategoryStatus] BIT NOT NULL DEFAULT 1,
)