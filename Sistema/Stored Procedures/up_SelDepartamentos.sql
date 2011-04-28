USE [Factoring]
GO
/****** Object:  StoredProcedure [dbo].[up_SelDepartamentos]    Script Date: 04/28/2011 08:33:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ROBERTO RAMOS GOMEZ
-- Create date: 22/03/2010
-- Description:	SELECCIONA TODOS LOS DEPARTAMENTOS
				
-- =============================================
ALTER PROCEDURE [dbo].[up_FASelDepartamentos]
AS
BEGIN	
	SET NOCOUNT ON

		SELECT * FROM UBIGEO WHERE CODPROVINCIA = '00' AND CODDISTRITO = '00'
		ORDER BY DESCRIPUBIGEO		

		
	SET NOCOUNT OFF
END
