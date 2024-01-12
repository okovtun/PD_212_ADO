CREATE TABLE [dbo].[Authors]
(
	[id]			INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[first_name]	NVARCHAR(100)	NOT NULL,
	[last_name]		NVARCHAR(100)	NOT NULL
)
GO

CREATE TABLE [dbo].[Books]
(
	[id]			INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[author]		INT NOT NULL,
	FOREIGN KEY (author)	REFERENCES Authors (id),
	[title]			NVARCHAR(200) NOT NULL,
	[price]			MONEY,
	[pages]			INT
)
GO