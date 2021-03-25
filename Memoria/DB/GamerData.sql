USE [Practice]
GO

/****** Object:  Table [dbo].[GamerData]    Script Date: 2019. 05. 03. 14:05:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GamerData](
	[GamerID] [int] IDENTITY(1,1) NOT NULL,
	[GamerName] [nchar](30) NOT NULL
) ON [PRIMARY]
GO

