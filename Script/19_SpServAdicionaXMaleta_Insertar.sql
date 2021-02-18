USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<INSERTAR SERVICIO ADICIONAL POR  MALETA >
-- =============================================
CREATE PROCEDURE SP_SERVADICIONALXMALETA_INSERTAR
@ServicioAdicionalID int,
@MaletaID int

AS

BEGIN

INSERT INTO [dbo].[SERVICIOADICIONAL_X_MALETA]
           ([ServicioAdicionalID]
           ,[MaletaID]
           ,[ServicioAdicionalXMaletaFecha])
     VALUES
           (@ServicioAdicionalID
           ,@MaletaID
           ,GETDATE())
END


