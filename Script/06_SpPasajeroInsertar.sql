USE [AgenciaViajesKY]
GO

-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<CONSULTAR PASAJERO>
-- =============================================

CREATE PROCEDURE SP_PASAJERO_CONSULTAR

AS

BEGIN

SELECT [PasajeroID]
      ,[PasajeroNombre]
      ,[PasajeroApellido]
      ,[TipoDocumentoID]
      ,[NumDocumento]
      ,[PasajeroTel]
      ,[PasajeroCorreo]
      ,[PasajeroFecha]
  FROM [dbo].[PASAJERO]



END
