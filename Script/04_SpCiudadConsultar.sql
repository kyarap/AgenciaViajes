USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<CONSULTAR Ciudades>
-- =============================================
CREATE PROCEDURE SP_CIUDAD_CONSULTAR
@PaisID INT 
AS

BEGIN
SELECT [CiudadID]
      ,[PaisID]
      ,[CiudadNombre]
      ,[CiudadFecha]
  FROM [dbo].[CIUDAD]
  WHERE PaisID=@PaisID


END


