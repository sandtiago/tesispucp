CREATE PROCEDURE up_SelDepartamentos
AS

BEGIN	
	SET NOCOUNT ON

		SELECT * 
		FROM Ubigeo 
		WHERE CodProvincia = '00' AND CodDistrito = '00'
		ORDER BY Descripcion		
		
	SET NOCOUNT OFF
END
