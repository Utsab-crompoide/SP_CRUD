USE [CRUD_sp]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Delete_Product]    Script Date: 7/28/2021 2:42:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE  [dbo].[Usp_Delete_Product](
 @ProductID int
)
AS
BEGIN
  Delete from Product Where Product_ID=@ProductId
	
END
