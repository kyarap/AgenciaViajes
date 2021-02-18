USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<CONSULTAR LOS SERVICIOS ADICIONALES>
-- =============================================
CREATE PROCEDURE SP_SERVICIOADICIONAL_CONSULTAR

AS


BEGIN

	SELECT [ServicioAdicionalID]
		  ,[ServicioAdicionalFecha]
		  ,[ServicioAdicionalDescripcion]
	  FROM [dbo].[SERVICIO_ADICIONAL]

END


