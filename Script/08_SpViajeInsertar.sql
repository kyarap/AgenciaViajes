USE [AgenciaViajesKY]
GO
/****** Object:  StoredProcedure [dbo].[SP_VIAJE_INSERTAR]    Script Date: 18/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<Insertar Viaje>
-- =============================================

CREATE PROCEDURE [dbo].[SP_VIAJE_INSERTAR]
@PasajeroID int,
@PaisOrigenID int,
@CiudadOrigenID int,
@PaisDestinoID int,
@CiudadDestinoID int,
@ViajeDeFecha datetime,
@TipoServicioID int = NULL,
@Estado bit,
@NumeroDeMaletas decimal(2,0)
AS
BEGIN



	INSERT INTO [dbo].[VIAJE]
           ([PasajeroID]
           ,[PaisOrigenID]
           ,[CiudadOrigenID]
           ,[PaisDestinoID]
           ,[CiudadDestinoID]
           ,[ViajeDeFecha]
           ,[TipoServicioID]
           ,[Estado]
           ,[NumeroDeMaletas])
     VALUES
           (@PasajeroID
           ,@PaisOrigenID
           ,@CiudadOrigenID
           ,@PaisDestinoID
           ,@CiudadDestinoID
           ,@ViajeDeFecha
           ,@TipoServicioID
           ,@Estado
           ,@NumeroDeMaletas)
END


