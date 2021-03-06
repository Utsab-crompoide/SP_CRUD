USE [CRUD_sp]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Update_Product]    Script Date: 7/28/2021 2:43:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Usp_Update_Product](
    @ProductID int,
    @Name varchar(50),
	@Quantity int,
	@Color varchar(50),
	@Price decimal(18,2),
	@ProductCode varchar(50)
	)
AS
BEGIN
	Update Product set 
	Name=@Name, Quantity=@Quantity, Color=@Color, Price=@Price, Product_Code=@ProductCode
	where Product_ID=@ProductId
END