USE [AgenciaViajesKY]
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<Insertar Viaje>
-- =============================================

CREATE PROCEDURE SP_VIAJE_INSERTAR
@PasajeroID int,
@PaisOrigenID int,
@CiudadOrigenID int,
@PaisDestinoID int,
@CiudadDestinoID int,
@ViajeDeFecha datetime,
@ServicioAdicionalID int = NULL
AS
BEGIN



	INSERT INTO [dbo].[VIAJE]
			   ([PasajeroID]
			   ,[PaisOrigenID]
			   ,[CiudadOrigenID]
			   ,[PaisDestinoID]
			   ,[CiudadDestinoID]
			   ,[ViajeDeFecha]
			   ,[ServicioAdicionalID])
		 VALUES
			   (@PasajeroID
			   ,@PaisOrigenID
			   ,@CiudadOrigenID
			   ,@PaisDestinoID
			   ,@CiudadDestinoID
			   ,@ViajeDeFecha
			   ,@ServicioAdicionalID)
END


