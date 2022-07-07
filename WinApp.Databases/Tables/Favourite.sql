CREATE TABLE [dbo].[Favourite](
	[FavouriteId] INT IDENTITY(1,1) PRIMARY KEY,
	[UserId] INT NOT NULL,
	[DocumentId] INT NOT NULL,
)