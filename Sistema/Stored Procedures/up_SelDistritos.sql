USE [Factoring]
GO
/****** Object:  StoredProcedure [dbo].[up_SelDistritos]    Script Date: 04/28/2011 08:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ROBERTO RAMOS GOMEZ
-- Create date: 24/03/2010
-- Description:	SELECCIONA DISTRITOS
				
-- =============================================
ALTER PROCEDURE [dbo].[up_FASelDistritos]
@CodDepartamento      char(2),
@CodProvincia         char(2)
AS

BEGIN	
	SET NOCOUNT ON

		SELECT * FROM UBIGEO WHERE CODDEPARTAMENTO = @CodDepartamento 
        AND CODPROVINCIA = @CodProvincia and CODDISTRITO <> '00'		

		
	SET NOCOUNT OFF
END
