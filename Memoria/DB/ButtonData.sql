USE [Practice]
GO

/****** Object:  Table [dbo].[ButtonData]    Script Date: 2019. 05. 03. 14:05:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ButtonData](
	[GameID] [int] NOT NULL,
	[ButtonNumber] [int] NOT NULL,
	[ButtonColor] [int] NOT NULL,
	[ButtonVisible] [int] NOT NULL
) ON [PRIMARY]
GO

