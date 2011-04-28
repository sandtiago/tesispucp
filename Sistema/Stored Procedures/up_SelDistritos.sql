CREATE PROCEDURE up_SelDistritos
@CodDepartamento      char(2),
@CodProvincia         char(2)
AS

BEGIN	
	SET NOCOUNT ON

		SELECT * 
		FROM Ubigeo 
		WHERE CodDepartamento = @CodDepartamento 
        AND CodProvincia = @CodProvincia and CodDistrito <> '00'
		
	SET NOCOUNT OFF
END
