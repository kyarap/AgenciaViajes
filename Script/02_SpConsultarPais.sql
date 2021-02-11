USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<CONSULTAR TODOS LOS PAISES>
-- =============================================
CREATE PROCEDURE SP_PAIS_CONSULTAR

AS

BEGIN
	SELECT [PaisID]
		  ,[PaisNombre]
		  ,[PaisFecha]
	  FROM [dbo].[PAIS]
END



