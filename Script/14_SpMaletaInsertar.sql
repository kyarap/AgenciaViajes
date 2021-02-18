USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<INSERTAR LA MALETA>
-- =============================================
CREATE PROCEDURE SP_MALETA_INSERTAR
@MaletaAlto decimal(5,2),
@MaletaLargo decimal(5,2),
@MaletaAncho decimal(5,2),
@MaletaPeso decimal(5,2),
@PasajeroID INT
AS

BEGIN
	INSERT INTO [dbo].[MALETA]
			   ([MaletaAlto]
			   ,[MaletaLargo]
			   ,[MaletaAncho]
			   ,[MaletaPeso]
			   ,[PasajeroID])
		 VALUES
			   (@MaletaAlto
			   ,@MaletaLargo
			   ,@MaletaAncho
			   ,@MaletaPeso
			   ,@PasajeroID)
END

