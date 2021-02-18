
CREATE database AgenciaViajesKY


USE  AgenciaViajesKY


/*CREACION TABLA PAIS*/
CREATE TABLE [dbo].[PAIS](
	[PaisID] [int] NOT NULL IDENTITY (1,1),
	[PaisNombre] [varchar](100) NOT NULL,	
	[PaisFecha] [datetime] NOT NULL DEFAULT GETDATE(),
PRIMARY KEY CLUSTERED 
(
	[PaisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



/*CREACION TABLA CIUDAD*/
CREATE TABLE [dbo].[CIUDAD](
	[CiudadID] [int] IDENTITY(1,1) NOT NULL,
	[PaisID] [int] NOT NULL,
	[CiudadNombre] [varchar](100) NOT NULL,
	[CiudadFecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CiudadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CIUDAD] ADD  DEFAULT (getdate()) FOR [CiudadDate]
GO

ALTER TABLE [dbo].[CIUDAD]  WITH CHECK ADD  CONSTRAINT [FK_CIUDAD_PAIS] FOREIGN KEY([PaisID])
REFERENCES [dbo].[PAIS] ([PaisID])
GO

ALTER TABLE [dbo].[CIUDAD] CHECK CONSTRAINT [FK_CIUDAD_PAIS]
GO




CREATE TABLE [dbo].[TIPO_SERVICIOS](
	[TipoServicioID] [int] NOT NULL IDENTITY (1,1),
	[TipoServicioNombre] [varchar](60) NOT NULL,	
	[TipoServicioFecha] [datetime] NOT NULL DEFAULT GETDATE(),
PRIMARY KEY CLUSTERED 
(
	[TipoServicioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[MALETA](
	[MaletaID] [int] NOT NULL IDENTITY (1,1),
	[MaletaAlto] decimal(5,2) NOT NULL,	
	[MaletaLargo] decimal(5,2) NOT NULL,
	[MaletaAncho] decimal(5,2) NOT NULL,
	[MaletaPeso] decimal(5,2) NOT NULL,
	[PasajeroID] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[MaletaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[SERVICIO_ADICIONAL](
	[ServicioAdicionalID] [int] IDENTITY(1,1) NOT NULL,
	[ServicioAdicionalFecha] [datetime] NOT NULL,
	[ServicioAdicionalDescripcion] [varchar](100) NOT NULL
PRIMARY KEY CLUSTERED 
(
	[ServicioAdicionalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SERVICIO_ADICIONAL] ADD  DEFAULT (getdate()) FOR [ServicioAdicionalFecha]
GO




/*CREACION DEL TIPO DE DOCUMENTO */
CREATE TABLE [dbo].[TIPO_DOCUMENTO](
	[TipoDocumentoID] [int] NOT NULL IDENTITY (1,1),
	[TipoDocumentoNombre] [varchar](100) NOT NULL,	
	[TipoDocumentoFecha] [datetime] NOT NULL DEFAULT GETDATE(),
PRIMARY KEY CLUSTERED 
(
	[TipoDocumentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




/*CREACION DEL PASAJERO*/
CREATE TABLE [dbo].[PASAJERO](
	[PasajeroID] [int] NOT NULL IDENTITY (1,1),
	[PasajeroNombre] [varchar](100) NOT NULL,	
	[PasajeroApellido] [varchar](100) NOT NULL,	
	[TipoDocumentoID] [int] NOT NULL, 
	[NumDocumento] VARCHAR (12) NOT NULL ,
	[PasajeroTel] VARCHAR (20) NOT NULL,
	[PasajeroCorreo] VARCHAR(50) NOT NULL,
	[PasajeroFecha] [datetime] NOT NULL DEFAULT GETDATE()
PRIMARY KEY CLUSTERED 
(
	[PasajeroID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO






CREATE TABLE [dbo].[VIAJE](
	[ViajeID] [int] IDENTITY(1,1) NOT NULL,
	[PasajeroID] [int] NOT NULL,
	[PaisOrigenID] [int] NOT NULL,
	[CiudadOrigenID] [int] NOT NULL,
	[PaisDestinoID] [int] NOT NULL,
	[CiudadDestinoID] [int] NOT NULL,
	[ViajeDeFecha] [datetime] NOT NULL,
	[TipoServicioID] [int] NOT NULL,
	[Estado][bit] NOT NULL ,
	[NumeroDeMaletas] [decimal](2, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ViajeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[VIAJE] ADD  DEFAULT (getdate()) FOR [ViajeDeFecha]
GO

ALTER TABLE [dbo].[VIAJE] ADD  DEFAULT (1) FOR [Estado]
GO

ALTER TABLE [dbo].[VIAJE] ADD  DEFAULT (0) FOR [NumeroDeMaletas]
GO




CREATE TABLE [dbo].[SERVICIOADICIONAL_X_MALETA](
	[ServicioAdicionalXMaletaID] [int] NOT NULL IDENTITY (1,1),
	[ServicioAdicionalID] INT NOT NULL ,	
	[MaletaID] [int] NOT NULL,
	[ServicioAdicionalXMaletaFecha] [datetime] NOT NULL DEFAULT GETDATE(),
PRIMARY KEY CLUSTERED 
(
	[ServicioAdicionalXMaletaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO





/*Insertar Registros*/


insert into pais select 'Colombia', getdate()

insert into CIUDAD SELECT 1,'Bogota',getdate()

insert into TIPO_DOCUMENTO select 'C.C.',getdate()
insert into TIPO_DOCUMENTO select 'C.E.',getdate()




-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<Insertar Viaje>
-- =============================================

ALTER PROCEDURE [dbo].[SP_VIAJE_INSERTAR]
@PasajeroID int,
@CiudadOrigenID int,
@CiudadDestinoID int,
@ViajeDeFecha datetime,
@TipoServicioID int = NULL,
@Estado bit,
@NumeroDeMaletas decimal(2,0)
AS
BEGIN



	INSERT INTO [dbo].[VIAJE]
           ([PasajeroID]
           ,[CiudadOrigenID]
           ,[CiudadDestinoID]
           ,[ViajeDeFecha]
           ,[TipoServicioID]
           ,[Estado]
           ,[NumeroDeMaletas])
     VALUES
           (@PasajeroID
           ,@CiudadOrigenID
           ,@CiudadDestinoID
           ,@ViajeDeFecha
           ,@TipoServicioID
           ,@Estado
           ,@NumeroDeMaletas)

		SELECT SCOPE_IDENTITY()
END

--///////////
/****** Object:  StoredProcedure [dbo].[SP_PASAJERO_INSERTAR]    Script Date: 18/02/2021 4:09:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<KYARA>
-- Create date: <10/02/2021>
-- Description:	<Insertar Pasajero>
-- =============================================
ALTER PROCEDURE [dbo].[SP_PASAJERO_INSERTAR]
@PasajeroNombre varchar(100),
@PasajeroApellido varchar(100),
@TipoDocumentoID INT,
@NumDocumento varchar(12),
@PasajeroTel varchar(20),
@PasajeroCorreo varchar(50),
@PasajeroFecha datetime
AS

BEGIN



INSERT INTO [dbo].[PASAJERO]
           ([PasajeroNombre]
           ,[PasajeroApellido]
           ,[TipoDocumentoID]
           ,[NumDocumento]
           ,[PasajeroTel]
           ,[PasajeroCorreo]
           ,[PasajeroFecha])
     VALUES
           (@PasajeroNombre
           ,@PasajeroApellido
           ,@TipoDocumentoID
           ,@NumDocumento
           ,@PasajeroTel
           ,@PasajeroCorreo
           ,@PasajeroFecha)

		SELECT SCOPE_IDENTITY()


END


