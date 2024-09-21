-- Crear Base de Datos
CREATE DATABASE db_Asistencia
GO
--Poner Activa la Base de Datos
USE db_Asistencia
GO

-- Creación de la tabla Horarios
CREATE TABLE Horario (
    IdHorario INT IDENTITY(1,1) PRIMARY KEY,
    FechaInicio DATE NULL,
    FechaFin DATE NULL,
    HoraEntrada TIME NOT NULL,
    HoraSalida TIME NOT NULL
)

-- Creación de la tabla Area
CREATE TABLE Area (
    IdArea INT IDENTITY(1,1) PRIMARY KEY,
	IdHorario INT NULL,
    NombreArea VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200) NOT NULL,
	FOREIGN KEY (IdHorario) REFERENCES Horario(IdHorario)
)

-- Creación de la tabla Empleados
CREATE TABLE Empleado (
    IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
	IdArea INT NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
	DNI CHAR(8) NOT NULL UNIQUE,
    Genero CHAR(1) NULL,
    Telefono VARCHAR(20) NULL,
	Estado CHAR(1) NULL,
    FOREIGN KEY (IdArea) REFERENCES Area(IdArea)
)

-- Creación de la tabla Puestos
CREATE TABLE Puesto (
    IdPuesto INT IDENTITY(1,1) PRIMARY KEY,
    NombrePuesto VARCHAR(80) NOT NULL,
    Descripcion VARCHAR(200) NOT NULL
)

-- Creación de la tabla Empleado_Puesto
CREATE TABLE Empleado_Puesto (
    IdEmpleado INT NOT NULL,
    IdPuesto INT NOT NULL,
    FechaInicio DATE NOT NULL,
    FechaFin DATE NULL,
    PRIMARY KEY (IdEmpleado, IdPuesto),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado),
    FOREIGN KEY (IdPuesto) REFERENCES Puesto(IdPuesto)
)

-- Creación de la tabla Asistencia
CREATE TABLE Asistencia (
    IdAsistencia INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpleado INT NOT NULL,
    FechaAsistencia DATE NOT NULL,
    HoraEntrada TIME NULL,
    HoraSalida TIME NULL,
    FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado)
)

--Tabla para Falta
CREATE TABLE Falta (
    IdFalta INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpleado INT NOT NULL,
    FechaFalta DATE NOT NULL,
    CONSTRAINT FK_Faltas_Empleado FOREIGN KEY (IdEmpleado) REFERENCES Empleado (IdEmpleado)
);

-- Creación de la tabla Usuario Credenciales para el sistema
CREATE TABLE Usuario(
	IdUsuario int identity(1,1) NOT NULL PRIMARY KEY,
	Nombre varchar(30) NOT NULL UNIQUE,
	Clave varchar(100) NOT NULL,
	Nivel varchar(15) NOT NULL,
	Estado int NOT NULL,
)
GO