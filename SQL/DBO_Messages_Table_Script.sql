USE [PT.Dev.Db]
GO

/****** Object:  Table [dbo].[Messages]    Script Date: 7/13/2021 4:25:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Messages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProfileName] [nvarchar](50) NOT NULL,
	[Recipient] [nvarchar](120) NOT NULL,
	[Subject] [nvarchar](250) NOT NULL,
	[Body] [nvarchar](max) NOT NULL,
	[CreatedBy] [int] NULL,
	[DateSent] [datetime2](7) NOT NULL
	CONSTRAINT PK_Message PRIMARY KEY (Id)
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Messages] ADD  CONSTRAINT [DF_Message_DateModified]  DEFAULT (getutcdate()) FOR [DateSent]
GO


