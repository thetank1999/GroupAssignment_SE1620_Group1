CREATE TABLE [dbo].[Role](
	[RoleId] INT IDENTITY(1,1) PRIMARY KEY,
	[RoleName] varchar(512) NOT NULL,
	[RoleStatus] BIT NOT NULL DEFAULT 1,
)