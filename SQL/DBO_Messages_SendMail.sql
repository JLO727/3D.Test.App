USE [PT.Dev.Db]
GO
/****** Object:  StoredProcedure [dbo].[Messages_SendMail]    Script Date: 7/13/2021 4:46:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------
/*
AUTHOR: James Lopez
DATE: 07/13/21
COMMENTS: Send DbMail Messages From .Net Application

*/
-------------------------

ALTER PROC [dbo].[Messages_SendMail]

	@ProfileName NVARCHAR(50)
	,@Recipient NVARCHAR(120)
	,@Subject NVARCHAR (250)
	,@Body NVARCHAR(MAX)

AS

/*
	DECLARE @ProfileName NVARCHAR(50) = '3D_Test'
			,@Recipient NVARCHAR(120) = 'jim@pro-tecit.com'
			,@Subject NVARCHAR (250) = 'Test Proc'
			,@Body NVARCHAR(MAX) = 'This is a test, should add message to the db'
			
	EXECUTE [DBO].[Messages_SendMail]

		@ProfileName
		,@Recipient
		,@Subject
		,@Body

	

*/

BEGIN

	EXECUTE [MSDB].[DBO].[sp_send_dbmail]
	
			@profile_name = @ProfileName
			,@recipients = @Recipient
			,@subject = @Subject
			,@body = @Body
			
END

