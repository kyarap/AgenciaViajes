USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<ACTUALIZAR LA MALETA>
-- =============================================
CREATE PROCEDURE SP_MALETA_ACTUALIZAR
@MaletaID INT,
@MaletaAlto decimal(5,2),
@MaletaLargo decimal(5,2),
@MaletaAncho decimal(5,2),
@MaletaPeso decimal(5,2),
@PasajeroID int
AS
BEGIN

	UPDATE [dbo].[MALETA]
	   SET [MaletaAlto] = @MaletaAlto
		  ,[MaletaLargo] = @MaletaLargo
		  ,[MaletaAncho] = @MaletaAncho
		  ,[MaletaPeso] = @MaletaPeso
		  ,[PasajeroID]= @PasajeroID
	 WHERE MaletaID=@MaletaID 
END


