USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<INSERTAR SERVICIO ADICIONAL>
-- =============================================
CREATE PROCEDURE SP_SERVICIOADIONAL_INSERTAR
@ServicioAdicionalDescripcion varchar(100)

AS

BEGIN
	INSERT INTO [dbo].[SERVICIO_ADICIONAL]
           ([ServicioAdicionalFecha]
           ,[ServicioAdicionalDescripcion])
     VALUES
           (GETDATE()
           ,@ServicioAdicionalDescripcion)
END


