USE [CRUD_sp]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Get_Productby_ProductId]    Script Date: 7/28/2021 2:24:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Usp_Get_Productby_ProductId](
	@ProductId int
	
)
AS
BEGIN
Select Product_ID as ProductId,
Name as Name,
Quantity as Quantity,
Color as Color,
Price as Price,
Product_Code as Product_Code
From Product Where Product_ID=@ProductId	
END
