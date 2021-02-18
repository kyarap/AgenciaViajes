USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<CONSULTAR SERVICIO ADICIONAL POR  MALETA >
-- =============================================

CREATE PROCEDURE SP_SERVADICIONALXMALETA_CONSULTAR

AS

BEGIN
	SELECT [ServicioAdicionalXMaletaID]
		  ,[ServicioAdicionalID]
		  ,[MaletaID]
		  ,[ServicioAdicionalXMaletaFecha]
	  FROM [dbo].[SERVICIOADICIONAL_X_MALETA]

END


