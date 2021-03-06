USE [PT.Dev.Db]
GO
/****** Object:  StoredProcedure [dbo].[Messages_Insert]    Script Date: 7/13/2021 4:46:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------
/*
AUTHOR: James Lopez
DATE: 07/12/21
COMMENTS: Store Messages From .Net Application

*/
-------------------------

ALTER PROC [dbo].[Messages_Insert]

	@ProfileName NVARCHAR(50)
	,@Recipient NVARCHAR(120)
	,@Subject NVARCHAR (250)
	,@Body NVARCHAR(MAX)
	,@CreatedBy int
	,@Id INT OUTPUT


AS

/*
	DECLARE @Id INT = 0


	DECLARE @ProfileName NVARCHAR(50) = '3D_Test'
			,@Recipient NVARCHAR(120) = 'jim@pro-tecit.com'
			,@Subject NVARCHAR (250) = 'Test Proc'
			,@Body NVARCHAR(MAX) = 'This is a test, should add message to the db'
			,@CreatedBy int = 12
			
	EXECUTE [DBO].[Messages_Insert]

		@ProfileName
		,@Recipient
		,@Subject
		,@Body
		,@CreatedBy
		,@Id output

	SELECT * FROM DBO.MESSAGES M
	WHERE M.Id = @Id

	

*/

BEGIN

	DECLARE @DatNow DATETIME2(7) = GETUTCDATE()

	INSERT INTO [DBO].[Messages]
			(
			[ProfileName]
			,[Recipient]
			,[Subject]
			,[Body]
			,[CreatedBy]
			,[DateSent]
			)
	VALUES	(
			@ProfileName
			,@Recipient
			,@Subject
			,@Body
			,@CreatedBy
			,@DatNow
			)
	SET @Id = SCOPE_IDENTITY()

	EXECUTE [DBO].[Messages_SendMail]
			@ProfileName
			,@Recipient
			,@Subject
			,@Body
			


END

