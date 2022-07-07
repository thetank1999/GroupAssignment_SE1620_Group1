CREATE TABLE [dbo].[Document](
	[DocumentId] INT IDENTITY(1,1) PRIMARY KEY,
	[MajorId] INT NOT NULL,
	[CategoryId] INT NOT NULL,
	[UploaderId] INT NOT NULL,
	[ApproverId] INT NOT NULL,
	[DocumentType] TEXT NOT NULL,
	[DocumentData] VARBINARY(MAX) NOT NULL,
	[DocumentUrl] TEXT NOT NULL,
	[DocumentStatus] BIT NOT NULL DEFAULT 1,
	[IsApproved] BIT NOT NULL DEFAULT 0
)