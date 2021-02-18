USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<CONSULTAR LA MALETA>
-- =============================================
CREATE PROCEDURE SP_MALETA_CONSULTAR

AS

BEGIN
	SELECT [MaletaID]
		  ,[MaletaAlto]
		  ,[MaletaLargo]
		  ,[MaletaAncho]
		  ,[MaletaPeso]
		  ,[PasajeroID]
	  FROM [dbo].[MALETA]

END


