USE [AgenciaViajesKY]
GO


-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<Insertar Pasajero>
-- =============================================
CREATE PROCEDURE SP_PASAJERO_INSERTAR
@PasajeroNombre varchar(100),
@PasajeroApellido varchar(100),
@TipoDocumentoID INT,
@NumDocumento varchar(12),
@PasajeroTel varchar(20),
@PasajeroCorreo varchar(50),
@PasajeroFecha datetime
AS

BEGIN



INSERT INTO [dbo].[PASAJERO]
           ([PasajeroNombre]
           ,[PasajeroApellido]
           ,[TipoDocumentoID]
           ,[NumDocumento]
           ,[PasajeroTel]
           ,[PasajeroCorreo]
           ,[PasajeroFecha])
     VALUES
           (@PasajeroNombre
           ,@PasajeroApellido
           ,@TipoDocumentoID
           ,@NumDocumento
           ,@PasajeroTel
           ,@PasajeroCorreo
           ,@PasajeroFecha)



END


