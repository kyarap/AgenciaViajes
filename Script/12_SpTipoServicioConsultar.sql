USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<CONSULTAR TODOS LOS TIPOS DE SERVICIO>
-- =============================================
CREATE PROCEDURE SP_TIPO_SERVICIO_CONSULTAR

AS

BEGIN
SELECT [TipoServicioID]
      ,[TipoServicioNombre]
      ,[TipoServicioFecha]
  FROM [dbo].[TIPO_SERVICIO]

END


