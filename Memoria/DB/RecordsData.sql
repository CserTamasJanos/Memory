USE [Practice]
GO

/****** Object:  Table [dbo].[RecordsData]    Script Date: 2019. 05. 03. 14:06:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RecordsData](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[GamerID] [int] NOT NULL,
	[RecordDateTime] [datetime] NOT NULL,
	[ClickNumber] [int] NOT NULL,
	[GameTime] [int] NOT NULL,
	[Score] [int] NOT NULL
) ON [PRIMARY]
GO

