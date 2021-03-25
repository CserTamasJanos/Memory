USE [Practice]
GO

/****** Object:  Table [dbo].[GameSave]    Script Date: 2019. 05. 03. 14:05:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GameSave](
	[GameID] [int] IDENTITY(1,1) NOT NULL,
	[SaveGameTime] [int] NOT NULL,
	[SaveDateTime] [datetime] NOT NULL,
	[GamerID] [int] NOT NULL,
	[GamerClickCount] [int] NOT NULL
) ON [PRIMARY]
GO

