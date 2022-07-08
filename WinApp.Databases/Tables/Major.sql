CREATE TABLE [dbo].[Major](
	[MajorId] INT IDENTITY(1,1) PRIMARY KEY,
	[MajorName] varchar(512) NOT NULL,
	[MajorStatus] BIT NOT NULL DEFAULT 1,
)