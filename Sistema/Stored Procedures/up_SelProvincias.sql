USE [Factoring]
GO
/****** Object:  StoredProcedure [dbo].[up_FASelProvincias]    Script Date: 04/28/2011 08:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		ROBERTO RAMOS GOMEZ
-- Create date: 28/03/2010
-- Description:	PROVINCIAS
				
-- =============================================
ALTER PROCEDURE [dbo].[up_FASelProvincias]
@CodDepartamento		char(2)
AS
BEGIN	
	SET NOCOUNT ON									
		
		SELECT * FROM UBIGEO
		WHERE CODDEPARTAMENTO	= @CodDepartamento	AND
		CODPROVINCIA			<> '00'				AND
		CODDISTRITO				= '00'
						
	SET NOCOUNT OFF
END
