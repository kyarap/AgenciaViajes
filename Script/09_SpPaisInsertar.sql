USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<Insertar Pais>
-- =============================================
CREATE PROCEDURE SP_PAIS_INSERTAR

@PaisNombre varchar(100),
@PaisFecha datetime
AS

BEGIN
INSERT INTO [dbo].[PAIS]
           ([PaisNombre]
           ,[PaisFecha])
     VALUES
           (@PaisNombre
           ,@PaisFecha)
END


