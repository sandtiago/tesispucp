CREATE PROCEDURE up_SelProvincias
@CodDepartamento		char(2)
AS

BEGIN	
	SET NOCOUNT ON									
		
		SELECT * 
		FROM Ubigeo
		WHERE CodDepartamento = @CodDepartamento AND CodProvincia <> '00' AND CodDistrito = '00'
						
	SET NOCOUNT OFF
END
