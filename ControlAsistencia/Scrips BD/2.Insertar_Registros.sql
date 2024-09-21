-- Inserción de datos en la tabla Horario
INSERT INTO Horario (FechaInicio, FechaFin, HoraEntrada, HoraSalida)
VALUES 
    ('2023-01-01', '2023-12-31', '08:00:00', '17:00:00'),
    ('2023-01-01', '2023-12-31', '08:30:00', '17:30:00'),
    ('2023-01-01', '2023-12-31', '09:00:00', '18:00:00');

-- Inserción de datos en la tabla Departamentos
INSERT INTO Area (IdHorario, NombreArea, Descripcion)
VALUES 
    (1, 'Ventas', 'Departamento encargado de las ventas y generación de ingresos'),
    (3, 'Recursos Humanos', 'Departamento encargado de la gestión del personal y el desarrollo organizacional'),
    (3, 'Contabilidad', 'Departamento encargado de la gestión de la contabilidad y las finanzas de la empresa'),
    (3, 'Legal', 'Departamento encargado de la asesoría legal y el cumplimiento normativo'),
    (1, 'TI', 'Departamento encargado de la gestión y el soporte de la infraestructura tecnológica'),
    (2, 'Marketing', 'Departamento encargado de desarrollar y ejecutar estrategias de marketing de la empresa');

-- Inserción de datos en la tabla Puesto
INSERT INTO Puesto (NombrePuesto, Descripcion)
VALUES 
    ('Gerente de Ventas', 'Encargado de liderar y supervisar el equipo de ventas, así como cumplir con los objetivos establecidos.'),
    ('Vendedor', 'Encargado de realizar ventas y generar nuevos clientes para la empresa.'),
    ('Gerente de Recursos Humanos', 'Responsable de la gestión del talento humano en la organización'),
    ('Asistente Administrativo', 'Encargado de brindar apoyo administrativo y organizar la documentación de la empresa.'),
	('Gerente de Legal', 'Responsable de supervisar y gestionar los casos en contrra de la organización.'),
    ('Asesor', 'Encargado de brindar que se cumplan con todos los aspectos legales'),
    ('Gerente de Contabilidad', 'Responsable de supervisar y gestionar los aspectos financieros y contables de la organización.'),
    ('Auditor', 'Encargado evaluar los registros financieros y operativos de la empresa para asegurar el cumplimiento de normas y políticas establecidas.'),
    ('Gerente de TI', 'Responsable de supervisar y gestionar los recursos y sistemas de tecnología de la información en la organización.'),
    ('Técnico TI', 'Encargado de brindar soporte técnico y resolver problemas relacionados con la tecnología de la información.'),
    ('Gerente de Marketing', 'Responsable de diseñar y ejecutar estrategias de marketing para promover los productos o servicios de la empresa.'),
    ('Diseñador', 'Encargado de crear diseños gráficos y visuales para diversos fines de la empresa, como publicidad y branding.');

-- Inserción de datos en la tabla Empleado
INSERT INTO Empleado (IdArea, Nombre, Apellido, DNI, Genero, Telefono, Estado)
VALUES 
    -- Ventas
	(1, 'Juan', 'Perez', '11111111', 'M', '1234567890', 'A'),
    (1, 'Miguel', 'Gonzales', '11111112', 'M', '0987654321', 'A'),
    (1, 'Dhana', 'Scot', '11111113', 'F',  '5678901234', 'A'),
    (1, 'Emily', 'Caceres', '11111114', 'F', '0123456789', 'I'),
	--Recursos Humanos
    (2, 'David', 'Montalvo', '12121212', 'M', '9876543210', 'A'),
	(2, 'Luisa', 'Montenegro', '13131313', 'M', '9876543210', 'A'),
	(2, 'Pedro', 'Mamani', '14141414', 'M', '9876543210', 'A'),
    (2, 'Sarah', 'Quispe', '15151515', 'F',  '5678901234', 'I'),
	--Contabilidad
	(3, 'Jose', 'Garcia', '25252525', 'M', '9876543210', 'A'),
	(3, 'Mariella', 'Torres', '26262626', 'M', '9876543210', 'A'),
	(3, 'Liliana', 'Cardenas', '27272727', 'M', '9876543210',  'A'),
	(3, 'Oriele', 'Romero', '28282828', 'M', '9876543210', 'I'),
	--Legal
	(4, 'David', 'Ortega', '29292929', 'M', '9876543210', 'A'),
	(4, 'Jorge', 'Diaz', '30303030', 'M', '9876543210', 'A'),
	(4, 'Mike', 'Roos', '31313131', 'M', '9876543210', 'A'),
	(4, 'Micaela', 'Zane', '32323232', 'M', '9876543210', 'I'),
	--TI
	(5, 'Angel', 'Hernandez', '33333333', 'M', '9876543210', 'A'),
	(5, 'Jesus', 'Huallpa', '4444444', 'M', '9876543210', 'A'),
	(5, 'Brayar', 'Lopez', '55555555', 'M', '9876543210', 'A'),
	(5, 'Jorge', 'Brice', '66666666', 'M', '9876543210', 'I'),
	--Marketing
	(6, 'Gabriel', 'Rivera', '41414141', 'M', '9876543210', 'A'),
	(6, 'Ivan', 'Mostajo', '42424242', 'M', '9876543210', 'A'),
	(6, 'Elsa', 'Vega', '43434343', 'F', '9876543210', 'A'),
	(6, 'Yuli', 'Mejia', '44444444', 'F', '9876543210', 'I');

-- Inserción de datos en la tabla Empleado_Puesto
INSERT INTO Empleado_Puesto (IdEmpleado, IdPuesto, FechaInicio, FechaFin)
VALUES 
    (1, 1, '2023-01-01', '2023-12-31'),
    (2, 1, '2023-01-02', '2023-12-31'),
    (3, 1, '2023-01-01', '2023-12-31'),
	(4, 1, '2023-01-01', '2023-12-31'),
    (5, 2, '2023-02-01', '2023-12-31'),
    (6, 2, '2023-03-01', '2023-12-31'),
	(7, 2, '2023-01-01', '2023-12-31'),
    (8, 2, '2023-02-01', '2023-12-31'),
    (9, 3, '2023-03-01', '2023-12-31'),
	(10, 3, '2023-01-01', '2023-12-31'),
    (11, 3, '2023-01-02', '2023-12-31'),
    (12, 3, '2023-01-01', '2023-12-31'),
	(13, 4, '2023-01-01', '2023-12-31'),
    (14, 4, '2023-02-01', '2023-12-31'),
    (15, 4, '2023-03-01', '2023-12-31'),
	(16, 4, '2023-01-01', '2023-12-31'),
    (17, 5, '2023-02-01', '2023-12-31'),
    (18, 5, '2023-03-01', '2023-12-31'),
    (19, 5, '2023-01-02', '2023-12-31'),
    (20, 5, '2023-01-01', '2023-12-31'),
	(21, 6, '2023-01-01', '2023-12-31'),
    (22, 6, '2023-02-01', '2023-12-31'),
    (23, 6, '2023-03-01', '2023-12-31'),
	(24, 6, '2023-01-01', '2023-12-31');

-- Inserción de datos en la tabla Asistencia
INSERT INTO Asistencia (IdEmpleado, FechaAsistencia, HoraEntrada, HoraSalida)
VALUES 
    (1, '2023-06-28', '07:15:00', '17:00:00'),
    (2, '2023-06-28', '07:19:00', '18:15:00'),
    (3, '2023-06-28', '07:20:00', '17:30:00'),
	(4, '2023-06-28', '07:25:00', '17:00:00'),
    (5, '2023-06-28', '07:45:00', '18:15:00'),
    (6, '2023-06-28', '07:55:00', '17:30:00'),
	(7, '2023-06-28', '07:58:00', '17:00:00'),
    (8, '2023-06-28', '07:59:00', '18:15:00'),
    (9, '2023-06-28', '08:00:00', '17:30:00'),
	(10, '2023-06-28', '08:01:00', '17:00:00'),
    (11, '2023-06-28', '08:10:00', '18:15:00'),
    (12, '2023-06-28', '08:14:00', '17:30:00'),
	(13, '2023-06-28', '08:18:00', '17:00:00'),
    (14, '2023-06-28', '08:19:00', '18:15:00'),
    (15, '2023-06-28', '08:30:00', '17:30:00'),
	(16, '2023-06-28', '08:33:00', '17:00:00'),
    (17, '2023-06-28', '09:00:00', '18:15:00'),
    (18, '2023-06-28', '09:30:00', '17:30:00'),
	(19, '2023-06-28', '09:31:00', '17:00:00'),
    (20, '2023-06-28', '09:32:00', '18:15:00'),
    (21, '2023-06-28', '09:34:00', '17:30:00'),
	(22, '2023-06-28', '09:39:00', '17:00:00'),
    (23, '2023-06-28', '09:40:00', '18:15:00'),
    (24, '2023-06-28', '09:41:00', '17:30:00'),
	(1, '2023-06-29', '07:45:00', '17:00:00'),
    (2, '2023-06-29', '07:49:00', '18:15:00'),
    (4, '2023-06-29', '07:52:00', '17:30:00'),
	(16, '2023-06-29', '07:53:00', '17:00:00'),
    (19, '2023-06-29', '08:15:00', '18:15:00'),
    (24, '2023-06-29', '08:30:00', '17:30:00');


-- Insertar usuario ADMINISTRADOR
INSERT INTO Usuario (Nombre, Clave, Nivel, Estado)
VALUES ('admin', 'admin2023', 'ADMINISTRADOR', 1);

-- Insertar usuario PUESTODECONTROL
INSERT INTO Usuario (Nombre, Clave, Nivel, Estado)
VALUES ('control', 'control2023', 'PUESTODECONTROL', 1);


SELECT * FROM Puesto
SELECT * FROM Falta
SELECT * FROM Area
SELECT * FROM Empleado_Puesto
SELECT * FROM Horario
SELECT * FROM Asistencia
SELECT * FROM Empleado
SELECT * FROM Usuario