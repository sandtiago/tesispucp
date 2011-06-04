USE [CentroSalud]
GO
/****** Object:  StoredProcedure [dbo].[up_ManEspecialidad]    Script Date: 06/04/2011 12:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[up_ManEspecialidad] (
@idEspecialidad	   INT,
@nombre			   VARCHAR(30),
@descripcion	   VARCHAR(200),
@estado			   VARCHAR(8),
@indicador		   INT --0: Insertar, 1: Modificar, 2: Eliminar, 3: Recuperar
)
AS

BEGIN
  BEGIN TRANSACTION
    IF @indicador = 0
    BEGIN
    
		INSERT INTO Especialidad (Nombre, Descripcion, Estado)
		VALUES (@nombre, @descripcion, @estado)
		
    END
    
    IF @indicador = 1
    BEGIN
		UPDATE Especialidad
		SET Nombre = @nombre, Descripcion = @descripcion, Estado=@estado
		WHERE Id_Especialidad = @idEspecialidad
    END
    
    IF @indicador = 2
    BEGIN
		UPDATE Especialidad
		SET Estado = 'INACTIVO'
		WHERE Id_Especialidad = @idEspecialidad
    END
    
    IF @indicador = 3
    BEGIN
		UPDATE Especialidad
		SET Estado = 'ACTIVO'
		WHERE Id_Especialidad = @idEspecialidad
    END
    
  IF @@ERROR <> 0
  BEGIN
    ROLLBACK TRANSACTION
	RETURN
  END
  COMMIT TRANSACTION
END