USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<CONSULTAR LOS TIPOS DE DOCUMENTO>
-- =============================================
CREATE PROCEDURE SP_TIPODOCUMENTO_CONSULTAR

AS
BEGIN
	SELECT [TipoDocumentoID]
		  ,[TipoDocumentoNombre]
		  ,[TipoDocumentoFecha]
	  FROM [dbo].[TIPO_DOCUMENTO]



END


