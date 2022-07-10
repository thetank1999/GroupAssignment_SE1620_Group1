CREATE TABLE [dbo].[User](
	[UserId] INT IDENTITY(1,1) PRIMARY KEY,
	[UserRoleId] INT NOT NULL,
	[UserEmail] varchar(512) NOT NULL,
	[UserFullname] varchar(512) NOT NULL,
	[UserPassword] varchar(512) NOT NULL,
	[UserStatus] BIT NOT NULL DEFAULT 1,
	[UserMajor] INT
)