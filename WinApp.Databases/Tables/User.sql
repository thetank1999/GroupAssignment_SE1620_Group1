﻿CREATE TABLE [dbo].[User](
	[UserId] INT IDENTITY(1,1) PRIMARY KEY,
	[UserRoleId] INT NOT NULL,
	[UserEmail] varchar(512) NOT NULL,
	[UserFullname] TEXT NOT NULL,
	[UserPassword] TEXT NOT NULL,
	[UserStatus] BIT NOT NULL DEFAULT 1
)