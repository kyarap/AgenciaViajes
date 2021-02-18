USE [AgenciaViajesKY]
GO
/****** Object:  StoredProcedure [dbo].[SP_CIUDAD_CONSULTAR]    Script Date: 17/02/2021 9:54:09 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<KYARA>
-- Create date: <17/02/2021>
-- Description:	<CONSULTAR DATOS DEL VIAJE>
-- =============================================
CREATE PROCEDURE SP_DATOSVIAJE_CONSULTAR 

AS
BEGIN

	SELECT  
	V.ViajeID ,
	V.PasajeroID,
	V.PaisOrigenID,
	PO.PaisNombre Pais_Origen,
	V.CiudadOrigenID,
	CO.CiudadNombre Ciudad_Origen,
	V.PaisDestinoID,
	PD.PaisNombre Pais_Destino,
	CD.CiudadNombre,
	V.CiudadDestinoID Ciudad_Destino,
	V.ViajeDeFecha,
	V.ServicioAdicionalID,
	P.PasajeroNombre,
	P.PasajeroApellido,
	P.TipoDocumentoID,
	D.TipoDocumentoNombre,
	P.NumDocumento,
	P.PasajeroTel,
	P.PasajeroCorreo,
	P.PasajeroFecha,
	SA.NumeroDeMaletas,
	SA.ServicioAdicionalFecha,
	SA.TipoDeServicioID,
	TS.TipoServicioNombre,
	TS.TipoServicioFecha,
	M.MaletaID,
	M.MaletaAlto,
	M.MaletaLargo,
	M.MaletaAncho,
	M.MaletaAPeso,
	M.MaletaIDFecha
	FROM VIAJE AS V with(nolock)
	LEFT JOIN PASAJERO AS P WITH(NOLOCK) ON V.PasajeroID = P.PasajeroID 
	LEFT JOIN TIPO_DOCUMENTO AS D WITH(NOLOCK) ON D.TipoDocumentoID=P.TipoDocumentoID
	LEFT JOIN SERVICIO_ADICIONAL AS SA WITH(NOLOCK) ON SA.ServicioAdicionalID=V.ServicioAdicionalID
	LEFT JOIN TIPO_SERVICIO AS TS WITH(NOLOCK) ON TS.TipoServicioID=SA.TipoDeServicioID	
	LEFT JOIN SERVICIOADICIONAL_X_MALETA AS SM WITH(NOLOCK) ON SM.ServicioAdicionalID=SA.ServicioAdicionalID
	LEFT JOIN MALETA AS M WITH(NOLOCK) ON M.MaletaID= SM.MaletaID
	LEFT JOIN PAIS AS PO WITH(NOLOCK) ON PO.PaisID=V.PaisOrigenID
	LEFT JOIN PAIS AS PD WITH(NOLOCK) ON PD.PaisID=V.PaisOrigenID
	LEFT JOIN [dbo].[CIUDAD] AS CO WITH(NOLOCK) ON  CO.CiudadID=V.CiudadOrigenID
	LEFT JOIN [dbo].[CIUDAD] AS CD WITH(NOLOCK) ON  CD.CiudadID=V.CiudadDestinoID


END
GO
