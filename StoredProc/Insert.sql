USE [CRUD_sp]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Insert_Product]    Script Date: 7/28/2021 2:43:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Usp_Insert_Product](
   
    @Name varchar(50),
	@Quantity int,
	@Color varchar(50),
	@Price decimal(18,2),
	@ProductCode varchar(50)
	 
	)

	
AS
BEGIN

INSERT INTO [dbo].[Product] (Name, Quantity, Color, Price, Product_Code) VALUES 
		(@Name, @Quantity, @Color, @Price, @ProductCode)
		Select @@IDENTITY
		END
		
