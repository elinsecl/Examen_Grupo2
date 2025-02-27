----------------- EXAMEN GRUPO 2 -----------------
-- Usamos MASTER para administrar la BD
USE MASTER;
GO
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
--------------------------------------------------------
-------------------- BASE DE DATOS ---------------------
--------------------------------------------------------
-- Verificamos si la base de datos existe, y en caso de existir la eliminamos
IF EXISTS (SELECT NAME FROM DBO.SYSDATABASES WHERE NAME = 'CentroComercialDB')
BEGIN
	DROP DATABASE CentroComercialDB;
END;
GO
-- Crear la base de datos
CREATE DATABASE CentroComercialDB;
GO
-- Procedemos a empezar a usar la base de datos creada
USE CentroComercialDB;
GO


----------------------------------------------------
-------------------- SERVICIOS ---------------------
----------------------------------------------------
-- Verificar que la tabla no existe en la BD y si existe eliminarla
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = 'Servicios')
BEGIN
	DROP TABLE Servicios;
END;
GO
-- Creamos la tabla Servicios
CREATE TABLE Servicios (
	IdServicio INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	NombreServicio VARCHAR(200) NOT NULL,
	Descripcion VARCHAR (1000) NOT NULL,
	Precio DECIMAL  NOT NULL,
	Duracion INT NOT NULL,
	Categoria VARCHAR (50) NOT NULL,
	Estado VARCHAR (20) NOT NULL,
	FechaCreacion DATE NOT NULL,
	Foto VARCHAR (500)
);
GO
--------------------------------------------
-------------- CRUD SERVICIOS --------------
--------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Ins_Servicio]')
BEGIN
	DROP TABLE [Sp_Ins_Servicio];
END;
GO
-------------- CREAR --------------
CREATE OR ALTER PROCEDURE [Sp_Ins_Servicio]
	@NombreServicio VARCHAR (200),
	@Descripcion VARCHAR (1000),
	@Precio DECIMAL,
	@Duracion INT,
	@Categoria VARCHAR (50),
	@Estado VARCHAR (20),
	@FechaCreacion DATE,
	@Foto VARCHAR (500)
AS
BEGIN 
		INSERT INTO Servicios (NombreServicio, Descripcion, Precio, Duracion, Categoria, Estado, FechaCreacion, Foto)
		VALUES (@NombreServicio, @Descripcion, @Precio, @Duracion, @Categoria, @Estado, @FechaCreacion, @Foto);

		PRINT 'Servicio insertado correctamente.';
END;
GO

Exec [Sp_Ins_Servicio] 'ADSF', 'FADF', '12000.00', '10', 'Salud', 'Activo','2024-07-14',''
go
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Buscar_NombresServicios]')
BEGIN
	DROP TABLE [Sp_Buscar_NombresServicios];
END;
GO
-------------- LEER --------------
CREATE OR ALTER PROCEDURE [Sp_Buscar_NombresServicios]
	@NombreServicio VARCHAR (200)
AS
BEGIN
		SELECT *
		FROM Servicios
		WHERE NombreServicio LIKE '%' + RTRIM(LTRIM(@NombreServicio)) + '%'
		ORDER BY NombreServicio;

		PRINT 'Búsqueda completada correctamente';
END;
GO 
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Buscar_IdServicio]')
BEGIN
	DROP TABLE [Sp_Buscar_IdServicio];
END;
GO
-------------- LEER --------------
CREATE OR ALTER PROCEDURE [Sp_Buscar_IdServicio]
	@IdServicio INT
AS
BEGIN
		SELECT *
		FROM Servicios
		WHERE IdServicio LIKE '%' + RTRIM(LTRIM(@IdServicio)) + '%'
		ORDER BY IdServicio;

		PRINT 'Búsqueda completada correctamente';
END;
GO 
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Upd_Servicio]')
BEGIN
	DROP TABLE [Sp_Upd_Servicio];
END;
GO
-------------- ACTUALIZAR --------------
CREATE OR ALTER PROCEDURE [Sp_Upd_Servicio]
	@IdServicio INT,
	@NombreServicio VARCHAR (200),
	@Descripcion VARCHAR (1000),
	@Precio DECIMAL (1,00),
	@Duracion INT,
	@Categoria VARCHAR (50),
	@Estado VARCHAR (20),
	@FechaCreacion DATE,
	@Foto VARCHAR (500)
AS
BEGIN
		UPDATE Servicios
		SET
			NombreServicio = @NombreServicio,
			Descripcion = @Descripcion,
			Precio = @Precio,
			Duracion = @Duracion,
			Categoria = @Categoria, 
			Estado = @Estado,
			FechaCreacion = @FechaCreacion,
			Foto = @Foto
		WHERE IdServicio = @IdServicio;

		PRINT 'Servicio actualizado correctamente.';
END;
GO
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Del_Servicio]')
BEGIN
	DROP TABLE [Sp_Del_Servicio];
END;
GO
-------------- ELIMINAR --------------
CREATE OR ALTER PROCEDURE [Sp_Del_Servicio]
	@IdServicio INT
AS
BEGIN
		DELETE FROM Servicios WHERE IdServicio = @IdServicio;

		PRINT 'Servicio eliminado correctamente';
END;
GO


----------------------------------------------------
-------------------- CLIENTES ---------------------
----------------------------------------------------
-- Verificar que la tabla no existe en la BD y si existe eliminarla
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = 'Clientes')
BEGIN
	DROP TABLE Clientes;
END;
GO
-- Creamos la tabla Clientes
CREATE TABLE Clientes (
	IdCliente INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	NombreCompleto VARCHAR(200) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	CorreoElectronico VARCHAR (255) NOT NULL,
	Telefono VARCHAR (15) NOT NULL,
	Direccion VARCHAR (500),
	FechaRegistro DATE NOT NULL,
	EstadoCuenta VARCHAR (20) NOT NULL,
	Foto VARCHAR (500)
);
GO
--------------------------------------------
-------------- CRUD CLIENTES --------------
--------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Ins_Cliente]')
BEGIN
	DROP TABLE [Sp_Ins_Cliente];
END;
GO
-------------- CREAR --------------
CREATE OR ALTER PROCEDURE [Sp_Ins_Cliente]
	@NombreCompleto VARCHAR (200),
	@FechaNacimiento DATE,
	@CorreoElectronico VARCHAR (255),
	@Telefono VARCHAR (15),
	@Direccion VARCHAR (500),
	@FechaRegistro DATE,
	@EstadoCuenta VARCHAR (20),
	@Foto VARCHAR (500)
AS
BEGIN 
		INSERT INTO Clientes (NombreCompleto, FechaNacimiento, CorreoElectronico, Telefono, Direccion, FechaRegistro, EstadoCuenta, Foto)
		VALUES (@NombreCompleto, @FechaNacimiento, @CorreoElectronico, @Telefono, @Direccion, @FechaRegistro, @EstadoCuenta, @Foto);

		PRINT 'Cliente insertado correctamente.';
END;
GO
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Buscar_NombresClientes]')
BEGIN
	DROP TABLE [Sp_Buscar_NombresClientes];
END;
GO
-------------- LEER --------------
CREATE OR ALTER PROCEDURE [Sp_Buscar_NombresClientes]
	@NombreCompleto VARCHAR (200)
AS
BEGIN
		SELECT *
		FROM Clientes
		WHERE NombreCompleto LIKE '%' + RTRIM(LTRIM(@NombreCompleto)) + '%'
		ORDER BY NombreCompleto;

		PRINT 'Búsqueda completada correctamente';
END;
GO 
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Buscar_IdCliente]')
BEGIN
	DROP TABLE [Sp_Buscar_IdCliente];
END;
GO
-------------- LEER --------------
CREATE OR ALTER PROCEDURE [Sp_Buscar_IdCliente]
	@IdCliente INT
AS
BEGIN
		SELECT *
		FROM Clientes
		WHERE IdCliente LIKE '%' + RTRIM(LTRIM(@IdCliente)) + '%'
		ORDER BY IdCliente;

		PRINT 'Búsqueda completada correctamente';
END;
GO 
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Upd_Cliente]')
BEGIN
	DROP TABLE [Sp_Upd_Cliente];
END;
GO
-------------- ACTUALIZAR --------------
CREATE OR ALTER PROCEDURE [Sp_Upd_Cliente]
	@IdCliente INT,
	@NombreCompleto VARCHAR (200),
	@FechaNacimiento DATE,
	@CorreoElectronico VARCHAR (255),
	@Telefono VARCHAR (15),
	@Direccion VARCHAR (500),
	@FechaRegistro DATE,
	@EstadoCuenta VARCHAR (20),
	@Foto VARCHAR (500)
AS
BEGIN
		UPDATE Clientes
		SET
			NombreCompleto = @NombreCompleto,
			FechaNacimiento = @FechaNacimiento,
			CorreoElectronico = @CorreoElectronico,
			Telefono = @Telefono,
			Direccion = @Direccion, 
			FechaRegistro = @FechaRegistro,
			EstadoCuenta = @EstadoCuenta,
			Foto = @Foto
		WHERE IdCliente = @IdCliente;

		PRINT 'Cliente actualizado correctamente.';
END;
GO
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Del_Cliente]')
BEGIN
	DROP TABLE [Sp_Del_Cliente];
END;
GO
-------------- ELIMINAR --------------
CREATE OR ALTER PROCEDURE [Sp_Del_Cliente]
	@IdCliente INT
AS
BEGIN
		DELETE FROM Clientes WHERE IdCliente = @IdCliente;

		PRINT 'Servicio eliminado correctamente';
END;
GO


----------------------------------------------------
-------------------- ENCUESTAS ---------------------
----------------------------------------------------
-- Verificar que la tabla no existe en la BD y si existe eliminarla
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = 'Encuestas')
BEGIN
	DROP TABLE Encuestas;
END;
GO
-- Creamos la tabla Servicios
CREATE TABLE Encuestas (
	IdEncuesta INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
	IdCliente INT,
	IdServicio INT NOT NULL,
	Comentarios VARCHAR (1000),
	FechaEncuesta DATE NOT NULL,
	CalificacionEncuesta VARCHAR (5) NOT NULL,
	TipoEncuesta VARCHAR (20) NOT NULL,
	EstadoEncuesta VARCHAR (20) NOT NULL,
	CONSTRAINT FK_Encuestas_Clientes FOREIGN KEY (IdCliente) REFERENCES Clientes (IdCliente),
	CONSTRAINT FK_Encuestas_Servicios FOREIGN KEY (IdServicio) REFERENCES Servicios (IdServicio)
);
GO
--------------------------------------------
-------------- CRUD ENCUESTAS --------------
--------------------------------------------

-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Ins_Encuesta]')
BEGIN
	DROP TABLE [Sp_Ins_Encuesta];
END;
GO
-------------- CREAR --------------
CREATE OR ALTER PROCEDURE [Sp_Ins_Encuesta]
	@IdCliente INT,
	@IdServicio INT,
	@Comentarios VARCHAR (1000),
	@FechaEncuesta DATE,
	@CalificacionEncuesta VARCHAR (5),
	@TipoEncuesta VARCHAR (20),
	@EstadoEncuesta VARCHAR (20)
AS
BEGIN 
		INSERT INTO Encuestas (IdCliente, IdServicio, Comentarios, FechaEncuesta, CalificacionEncuesta, TipoEncuesta, EstadoEncuesta)
		VALUES (@IdCliente, @IdServicio, @Comentarios, @FechaEncuesta, @CalificacionEncuesta, @TipoEncuesta, @EstadoEncuesta);

		PRINT 'Encuesta insertada correctamente.';
END;
GO
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Buscar_TiposEncuestas]')
BEGIN
	DROP TABLE [Sp_Buscar_TiposEncuestas];
END;
GO
-------------- LEER --------------
CREATE OR ALTER PROCEDURE [Sp_Buscar_TiposEncuestas]
	@TipoEncuesta VARCHAR (20)
AS
BEGIN
		SELECT *
		FROM Encuestas
		WHERE TipoEncuesta LIKE '%' + RTRIM(LTRIM(@TipoEncuesta)) + '%'
		ORDER BY TipoEncuesta;

		PRINT 'Búsqueda completada correctamente';
END;
GO 
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Buscar_IdEncuesta]')
BEGIN
	DROP TABLE [Sp_Buscar_IdEncuesta];
END;
GO
-------------- LEER --------------
CREATE OR ALTER PROCEDURE [Sp_Buscar_IdEncuesta]
	@IdEncuesta INT
AS
BEGIN
		SELECT *
		FROM Encuestas
		WHERE IdEncuesta LIKE '%' + RTRIM(LTRIM(@IdEncuesta)) + '%'
		ORDER BY IdEncuesta;

		PRINT 'Búsqueda completada correctamente';
END;
GO 
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Upd_Encuesta]')
BEGIN
	DROP TABLE [Sp_Upd_Encuesta];
END;
GO
-------------- ACTUALIZAR --------------
CREATE OR ALTER PROCEDURE [Sp_Upd_Encuesta]
	@IdEncuesta INT,
	@IdCliente INT,
	@IdServicio INT,
	@Comentarios VARCHAR (1000),
	@FechaEncuesta DATE,
	@CalificacionEncuesta VARCHAR (5),
	@TipoEncuesta VARCHAR (20),
	@EstadoEncuesta VARCHAR (20)
AS
BEGIN
		UPDATE Encuestas
		SET
			IdCliente = @IdCliente,
			IdServicio = @IdServicio,
			Comentarios = @Comentarios,
			FechaEncuesta = @FechaEncuesta,
			CalificacionEncuesta = @CalificacionEncuesta, 
			TipoEncuesta = @TipoEncuesta,
			EstadoEncuesta = @EstadoEncuesta
		WHERE IdEncuesta = @IdEncuesta;

		PRINT 'Encuesta actualizada correctamente.';
END;
GO
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-- Verificar que el procedimiento almacenado no exista en la BD
IF EXISTS (SELECT NAME FROM DBO.SYSOBJECTS WHERE NAME = '[Sp_Del_Encuesta]')
BEGIN
	DROP TABLE [Sp_Del_Encuesta];
END;
GO
-------------- ELIMINAR --------------
CREATE OR ALTER PROCEDURE [Sp_Del_Encuesta]
	@IdEncuesta INT
AS
BEGIN
		DELETE FROM Encuestas WHERE IdEncuesta = @IdEncuesta;

		PRINT 'Encuesta eliminada correctamente';
END;
GO







CREATE OR ALTER VIEW [Vp_Cns_Servicio]
AS
	SELECT s.IdServicio,
		s.NombreServicio,
		s.Descripcion,
		s.Precio,
		s.Duracion,
		s.Categoria,
		s.Estado,
		s.FechaCreacion
	FROM Servicios s
GO

