USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<CONSULTAR TODOS LOS PAISES>
-- =============================================
CREATE PROCEDURE SP_CIUDAD_CONSULTAR

AS

BEGIN
	SELECT [CiudadID]
		  ,[P].[PaisID]
		  ,[P].[PaisNombre]
		  ,[CiudadNombre]
		  ,[CiudadFecha]
	  FROM [dbo].[CIUDAD] AS C WITH(NOLOCK) 
	  INNER JOIN [dbo].[PAIS] AS P WITH(NOLOCK)  ON P.PaisID = C.PaisID
	  
END


