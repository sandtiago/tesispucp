USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManTipoDomicilio]    Script Date: 07/10/2011 21:16:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ManTipoDomicilio] (
@idDomicilio			INT,
@departamento			VARCHAR(40),
@provincia				VARCHAR(40),
@distrito				VARCHAR(40),
@direccion				VARCHAR(40),
@accion					INT, --0: Insertar, 1: Modificar
@idGenerado				INT		OUTPUT
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @accion = 0
    BEGIN
		INSERT INTO Domicilio (Departamento, Provincia, Distrito, Direccion)
		VALUES (@departamento, @provincia, @distrito, @direccion)
		
		SET @idGenerado = SCOPE_IDENTITY()
		
		RETURN @idGenerado
	END
    
    IF @accion = 1
    BEGIN
		UPDATE Domicilio
		SET Departamento = @departamento, Provincia = @provincia, Distrito = @distrito, Direccion = @direccion
		WHERE Id_Domicilio = @idDomicilio
		
		SET @idGenerado = 0
		
		RETURn @idGenerado	
	END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END