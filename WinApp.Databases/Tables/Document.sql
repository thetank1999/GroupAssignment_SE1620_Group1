CREATE TABLE [dbo].[Document](
	[DocumentId] INT IDENTITY(1,1) PRIMARY KEY,
	[MajorId] INT NOT NULL,
	[CategoryId] INT NOT NULL,
	[UploaderId] INT NOT NULL,
	[ApproverId] INT NOT NULL,
	[DocumentType] varchar(512) NOT NULL,
	[DocumentData] VARBINARY(MAX) NOT NULL,
	[DocumentUrl] varchar(512) NOT NULL,
	[DocumentStatus] BIT NOT NULL DEFAULT 1,
	[IsApproved] BIT NOT NULL DEFAULT 0
)