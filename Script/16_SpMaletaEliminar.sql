USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<ELIMINAR LA MALETA>
-- =============================================
CREATE PROCEDURE SP_MALETA_ELIMINAR
@MaletaID INT
AS
BEGIN


	DELETE FROM [dbo].[MALETA]
		  WHERE MaletaID=@MaletaID
END


