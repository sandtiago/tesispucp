USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_SelDepartamentos]    Script Date: 07/10/2011 21:18:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_SelDepartamentos]
AS

BEGIN	
	SET NOCOUNT ON

		SELECT * 
		FROM Ubigeo 
		WHERE CodProvincia = '00' AND CodDistrito = '00'
		ORDER BY Descripcion		
		
	SET NOCOUNT OFF
END
