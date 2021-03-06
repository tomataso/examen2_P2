USE [master]
GO
/****** Object:  Database [lab3_Proy2]    Script Date: 2/26/2021 7:07:13 AM ******/
CREATE DATABASE [lab3_Proy2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'lab3_Proy2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\lab3_Proy2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'lab3_Proy2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\lab3_Proy2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [lab3_Proy2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [lab3_Proy2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [lab3_Proy2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [lab3_Proy2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [lab3_Proy2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [lab3_Proy2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [lab3_Proy2] SET ARITHABORT OFF 
GO
ALTER DATABASE [lab3_Proy2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [lab3_Proy2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [lab3_Proy2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [lab3_Proy2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [lab3_Proy2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [lab3_Proy2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [lab3_Proy2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [lab3_Proy2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [lab3_Proy2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [lab3_Proy2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [lab3_Proy2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [lab3_Proy2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [lab3_Proy2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [lab3_Proy2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [lab3_Proy2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [lab3_Proy2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [lab3_Proy2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [lab3_Proy2] SET RECOVERY FULL 
GO
ALTER DATABASE [lab3_Proy2] SET  MULTI_USER 
GO
ALTER DATABASE [lab3_Proy2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [lab3_Proy2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [lab3_Proy2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [lab3_Proy2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [lab3_Proy2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [lab3_Proy2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'lab3_Proy2', N'ON'
GO
ALTER DATABASE [lab3_Proy2] SET QUERY_STORE = OFF
GO
USE [lab3_Proy2]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[cedula] [nchar](20) NOT NULL,
	[nombre] [nchar](30) NOT NULL,
	[apellido] [nchar](30) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[edad] [int] NOT NULL,
	[estado_civil] [nchar](10) NOT NULL,
	[genero] [nchar](10) NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Creditos]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Creditos](
	[id_credito] [int] IDENTITY(1,1) NOT NULL,
	[monto] [decimal](18, 4) NOT NULL,
	[tasa] [decimal](18, 4) NOT NULL,
	[nombre_linea] [nchar](20) NOT NULL,
	[cuota] [decimal](18, 4) NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[estado] [nchar](10) NOT NULL,
	[saldo] [decimal](18, 4) NOT NULL,
	[cliente_id] [nchar](20) NOT NULL,
 CONSTRAINT [PK_creditos] PRIMARY KEY CLUSTERED 
(
	[id_credito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas](
	[id_cuenta] [int] IDENTITY(1,1) NOT NULL,
	[moneda] [nchar](10) NOT NULL,
	[tipo] [nchar](10) NOT NULL,
	[saldo] [decimal](18, 4) NOT NULL,
	[cliente_id] [nchar](20) NOT NULL,
 CONSTRAINT [PK_cuentas] PRIMARY KEY CLUSTERED 
(
	[id_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direcciones]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direcciones](
	[id_direccion] [int] IDENTITY(1,1) NOT NULL,
	[provincia] [nchar](20) NOT NULL,
	[canton] [nchar](30) NOT NULL,
	[distrito] [nchar](40) NOT NULL,
	[detalles] [nchar](50) NOT NULL,
	[cliente_id] [nchar](20) NOT NULL,
 CONSTRAINT [PK_direcciones] PRIMARY KEY CLUSTERED 
(
	[id_direccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimientos]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimientos](
	[id_movimiento] [int] IDENTITY(1,1) NOT NULL,
	[fecha_movimiento] [date] NOT NULL,
	[tipo] [nchar](10) NOT NULL,
	[monto] [decimal](18, 4) NOT NULL,
	[cuenta_id] [int] NOT NULL,
 CONSTRAINT [PK_movimientos] PRIMARY KEY CLUSTERED 
(
	[id_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[fecha_pago] [date] NOT NULL,
	[monto] [decimal](18, 4) NOT NULL,
	[credito_id] [int] NOT NULL,
 CONSTRAINT [PK_pagos] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Creditos]  WITH CHECK ADD  CONSTRAINT [FK_creditos_clientes] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[Clientes] ([cedula])
GO
ALTER TABLE [dbo].[Creditos] CHECK CONSTRAINT [FK_creditos_clientes]
GO
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_cuentas_clientes] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[Clientes] ([cedula])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_cuentas_clientes]
GO
ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD  CONSTRAINT [FK_direcciones_clientes] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[Clientes] ([cedula])
GO
ALTER TABLE [dbo].[Direcciones] CHECK CONSTRAINT [FK_direcciones_clientes]
GO
ALTER TABLE [dbo].[Movimientos]  WITH CHECK ADD  CONSTRAINT [FK_movimientos_cuentas] FOREIGN KEY([cuenta_id])
REFERENCES [dbo].[Cuentas] ([id_cuenta])
GO
ALTER TABLE [dbo].[Movimientos] CHECK CONSTRAINT [FK_movimientos_cuentas]
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_pagos_creditos] FOREIGN KEY([credito_id])
REFERENCES [dbo].[Creditos] ([id_credito])
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_pagos_creditos]
GO
/****** Object:  StoredProcedure [dbo].[CREATE_CLIENTE_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CREATE_CLIENTE_PR] (@P_cedula nchar(20), @P_nombre nchar(30), @P_apellido nchar(30), @P_fecha_nacimiento date, @P_edad int, @P_estado_civil nchar(10), @P_genero nchar(10))
AS
INSERT INTO Clientes (cedula, nombre, apellido, fecha_nacimiento, edad, estado_civil , genero)
VALUES (@P_cedula, @P_nombre , @P_apellido , @P_fecha_nacimiento , @P_edad , @P_estado_civil , @P_genero)
GO
/****** Object:  StoredProcedure [dbo].[CREATE_CREDITO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CREATE_CREDITO_PR] (@P_monto decimal(18,4), @P_tasa decimal(18,4), @P_nombre_linea nchar(20), @P_cuota decimal(18,4),  @P_fecha_inicio date, @P_estado  nchar(20), @P_saldo nchar(20), @P_cliente_id nchar(20))
As
INSERT INTO Creditos( monto, tasa, nombre_linea, cuota, fecha_inicio, estado, saldo, cliente_id)
VALUES ( @P_monto, @P_tasa, @P_nombre_linea, @P_cuota,  @P_fecha_inicio, @P_estado , @P_saldo , @P_cliente_id )
GO
/****** Object:  StoredProcedure [dbo].[CREATE_CUENTA_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CREATE_CUENTA_PR] (@P_moneda nchar(10), @P_tipo nchar(10), @P_saldo decimal(18,4), @P_cliente_id nchar(20))
As
INSERT INTO Cuentas ( moneda, tipo, saldo, cliente_id)
VALUES ( @P_moneda, @P_tipo , @P_saldo , @P_cliente_id )
GO
/****** Object:  StoredProcedure [dbo].[CREATE_DIRECCION_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CREATE_DIRECCION_PR] (@P_provincia nchar(20), @P_canton nchar(30), @P_distrito nchar(40), @P_detalles nchar(50), @P_cliente_id nchar(20))
As
INSERT INTO Direcciones ( provincia, canton, distrito, detalles, cliente_id)
VALUES (@P_provincia, @P_canton , @P_distrito , @P_detalles , @P_cliente_id)
GO
/****** Object:  StoredProcedure [dbo].[CREATE_MOVIMIENTO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CREATE_MOVIMIENTO_PR] (@P_fecha_movimiento date, @P_tipo nchar(10), @P_monto decimal(18,4), @P_cuenta_id int)
As
INSERT INTO Movimientos ( fecha_movimiento, tipo, monto, cuenta_id)
VALUES ( @P_fecha_movimiento, @P_tipo , @P_monto , @P_cuenta_id )
GO
/****** Object:  StoredProcedure [dbo].[CREATE_PAGO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CREATE_PAGO_PR] (@P_fecha_pago date,  @P_monto decimal(18,4), @P_credito_id int)
As
INSERT INTO Pagos ( fecha_pago, monto, credito_id)
VALUES ( @P_fecha_pago, @P_monto , @P_credito_id )
GO
/****** Object:  StoredProcedure [dbo].[DEL_CLIENTE_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEL_CLIENTE_PR] (@P_cedula nchar(20))
AS
DELETE Cuentas
WHERE cliente_id = @P_cedula 
DELETE Direcciones
WHERE cliente_id = @P_cedula 
DELETE Creditos
WHERE cliente_id = @P_cedula 
DELETE Clientes
WHERE cedula = @P_cedula 
GO
/****** Object:  StoredProcedure [dbo].[DEL_CREDITO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEL_CREDITO_PR] (@P_id_credito int)
AS
DELETE Pagos
WHERE credito_id = @P_id_credito
DELETE Creditos
WHERE id_credito = @P_id_credito
GO
/****** Object:  StoredProcedure [dbo].[DEL_CUENTA_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEL_CUENTA_PR] (@P_id_cuenta int)
AS
DELETE Movimientos
WHERE cuenta_id = @P_id_cuenta
DELETE Cuentas
WHERE id_cuenta = @P_id_cuenta
GO
/****** Object:  StoredProcedure [dbo].[DEL_DIRECCION_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEL_DIRECCION_PR] (@P_id_direccion int)
AS
DELETE Direcciones
WHERE id_direccion = @P_id_direccion
GO
/****** Object:  StoredProcedure [dbo].[DEL_MOVIMIENTO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEL_MOVIMIENTO_PR] (@P_id_movimiento int)
AS
DELETE Movimientos
WHERE id_movimiento = @P_id_movimiento
GO
/****** Object:  StoredProcedure [dbo].[DEL_PAGO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEL_PAGO_PR] (@P_id_pago int)
AS
DELETE Pagos
WHERE id_pago = @P_id_pago
GO
/****** Object:  StoredProcedure [dbo].[RET_ALL_CLIENTES_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_ALL_CLIENTES_PR]
AS
SELECT * FROM Clientes
GO
/****** Object:  StoredProcedure [dbo].[RET_ALL_CREDITOS_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_ALL_CREDITOS_PR]
AS
SELECT * FROM Creditos
GO
/****** Object:  StoredProcedure [dbo].[RET_ALL_CUENTAS_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_ALL_CUENTAS_PR]
AS
SELECT * FROM Cuentas
GO
/****** Object:  StoredProcedure [dbo].[RET_ALL_DIRECCIONES_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_ALL_DIRECCIONES_PR]
AS
SELECT * FROM Direcciones
GO
/****** Object:  StoredProcedure [dbo].[RET_ALL_MOVIMIENTOS_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_ALL_MOVIMIENTOS_PR]
AS
SELECT * FROM Movimientos
GO
/****** Object:  StoredProcedure [dbo].[RET_ALL_PAGOS_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_ALL_PAGOS_PR]
AS
SELECT * FROM Pagos
GO
/****** Object:  StoredProcedure [dbo].[RET_CLIENTE_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_CLIENTE_PR] (@P_cedula nchar(20))
AS
SELECT * FROM Clientes WHERE cedula = @P_cedula
GO
/****** Object:  StoredProcedure [dbo].[RET_CREDITO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_CREDITO_PR] (@P_id_credito int)
AS
SELECT * FROM Creditos WHERE id_credito = @P_id_credito
GO
/****** Object:  StoredProcedure [dbo].[RET_CUENTA_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_CUENTA_PR] (@P_id_cuenta int)
AS
SELECT * FROM Cuentas WHERE id_cuenta = @P_id_cuenta
GO
/****** Object:  StoredProcedure [dbo].[RET_DIRECCION_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_DIRECCION_PR] (@P_id_direccion int)
AS
SELECT * FROM Direcciones WHERE id_direccion = @P_id_direccion
GO
/****** Object:  StoredProcedure [dbo].[RET_MOVIMIENTO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_MOVIMIENTO_PR] (@P_id_movimiento int)
AS
SELECT * FROM Movimientos WHERE id_movimiento = @P_id_movimiento
GO
/****** Object:  StoredProcedure [dbo].[RET_PAGO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RET_PAGO_PR] (@P_id_pago int)
AS
SELECT * FROM Pagos WHERE id_pago  = @P_id_pago 
GO
/****** Object:  StoredProcedure [dbo].[UPD_CLIENTE_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPD_CLIENTE_PR] (@P_cedula nchar(20), @P_nombre nchar(30), @P_apellido nchar(30), @P_fecha_nacimiento date, @P_edad int, @P_estado_civil nchar(10), @P_genero nchar(10))
AS
UPDATE Clientes SET  nombre = @P_nombre , apellido = @P_apellido , fecha_nacimiento = @P_fecha_nacimiento, edad = @P_edad , estado_civil = @P_estado_civil, genero = @P_genero 
WHERE cedula = @P_cedula
GO
/****** Object:  StoredProcedure [dbo].[UPD_CREDITO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPD_CREDITO_PR] (@P_id_credito int,@P_monto decimal(18,4), @P_tasa decimal(18,4), @P_nombre_linea nchar(20), @P_cuota decimal(18,4),  @P_fecha_inicio date, @P_estado  nchar(20), @P_saldo nchar(20), @P_cliente_id nchar(20))
AS
UPDATE Creditos SET  monto = @P_monto, tasa = @P_tasa, nombre_linea = @P_nombre_linea, cuota = @P_cuota , fecha_inicio = @P_fecha_inicio, estado = @P_estado, saldo =  @P_saldo, cliente_id = @P_cliente_id 
WHERE id_credito= @P_id_credito
GO
/****** Object:  StoredProcedure [dbo].[UPD_CUENTA_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPD_CUENTA_PR] (@P_id_cuenta int, @P_moneda nchar(10), @P_tipo nchar(10), @P_saldo decimal(18,4), @P_cliente_id nchar(20))
AS
UPDATE Cuentas SET   moneda = @P_moneda , tipo = @P_tipo , saldo = @P_saldo , cliente_id = @P_cliente_id
WHERE id_cuenta = @P_id_cuenta
GO
/****** Object:  StoredProcedure [dbo].[UPD_DIRECCION_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPD_DIRECCION_PR] (@P_id_direccion int, @P_provincia nchar(20), @P_canton nchar(30), @P_distrito nchar(40), @P_detalles nchar(50), @P_cliente_id nchar(20))
AS
UPDATE Direcciones SET  provincia = @P_provincia, canton = @P_canton, distrito = @P_distrito, detalles = @P_detalles, cliente_id = @P_cliente_id
WHERE id_direccion = @P_id_direccion
GO
/****** Object:  StoredProcedure [dbo].[UPD_MOVIMIENTO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPD_MOVIMIENTO_PR] (@P_id_movimiento int, @P_fecha_movimiento date, @P_tipo nchar(10), @P_monto decimal(18,4), @P_cuenta_id int)
AS
UPDATE Movimientos SET  fecha_movimiento = @P_fecha_movimiento, tipo = @P_tipo, monto = @P_monto, cuenta_id = @P_cuenta_id 
WHERE id_movimiento = @P_id_movimiento
GO
/****** Object:  StoredProcedure [dbo].[UPD_PAGO_PR]    Script Date: 2/26/2021 7:07:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPD_PAGO_PR] (@P_id_pago int, @P_fecha_pago date,  @P_monto decimal(18,4), @P_credito_id int)
AS
UPDATE Pagos SET  fecha_pago = @P_fecha_pago, monto = @P_monto, credito_id = @P_credito_id 
WHERE id_pago = @P_id_pago
GO
USE [master]
GO
ALTER DATABASE [lab3_Proy2] SET  READ_WRITE 
GO
