-- Buscar Empleado
CREATE PROCEDURE SP_BuscarEmpleado
    @buscar VARCHAR(50)
AS
BEGIN
    SELECT 
        e.IdEmpleado,
		d.NombreArea,
        e.Nombre,
        e.Apellido,
        e.DNI,
        e.Genero,
        e.Telefono,
        e.Estado
    FROM 
        Empleado AS e
    INNER JOIN 
        Area AS d ON e.IdArea = d.IdArea
    WHERE 
        e.Nombre LIKE '%' + @buscar + '%'
        OR e.Apellido LIKE '%' + @buscar + '%'
        OR e.DNI LIKE '%' + @buscar + '%'
END

EXEC SP_BuscarEmpleado @buscar = '12'

--Buscar Empleado por tardanza
CREATE PROCEDURE SP_ObtenerTardanzas
    @buscar VARCHAR(50),
    @dia DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        E.IdEmpleado,
        E.Nombre,
        E.Apellido,
        A.FechaAsistencia,
        A.HoraEntrada,
        H.HoraEntrada AS HoraEntradaEsperada,
        D.NombreArea AS Area,
        CASE
            WHEN A.HoraEntrada > H.HoraEntrada THEN
                DATEDIFF(MINUTE, H.HoraEntrada, A.HoraEntrada)
            ELSE
                0
        END AS TardanzaEnMinutos
    FROM
        Asistencia AS A
        INNER JOIN Empleado AS E ON A.IdEmpleado = E.IdEmpleado
        INNER JOIN Area AS D ON E.IdArea = D.IdArea
        INNER JOIN Horario AS H ON D.IdHorario = H.IdHorario
            AND A.FechaAsistencia BETWEEN H.FechaInicio AND H.FechaFin
    WHERE
        D.NombreArea LIKE '%' + @buscar + '%'
        AND DATEPART(DAY, A.FechaAsistencia) = DATEPART(DAY, @dia)
END;

EXEC SP_ObtenerTardanzas @buscar = 'Legal', @dia = '2023-06-29'

CREATE PROCEDURE SP_ObtenerFaltasPorEmpleado
    @buscar VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FechaActual DATE = GETDATE();

    -- Verificar si el empleado ya tiene falta registrada en la fecha actual
    IF EXISTS (
        SELECT 1
        FROM Falta
        WHERE IdEmpleado IN (
            SELECT IdEmpleado
            FROM Empleado
            WHERE Nombre LIKE '%' + @buscar + '%' OR
                Apellido LIKE '%' + @buscar + '%' OR
                DNI LIKE '%' + @buscar + '%'
            )
            AND FechaFalta = @FechaActual
    )
    BEGIN
        -- Si el empleado ya tiene falta registrada, no se realiza ninguna inserción
        SELECT
            e.IdEmpleado,
            e.Nombre,
            e.Apellido,
            COUNT(*) AS Falta
        FROM
            Empleado AS e
            INNER JOIN Falta AS f ON e.IdEmpleado = f.IdEmpleado
                                    AND f.FechaFalta = @FechaActual
        WHERE
            e.Nombre LIKE '%' + @buscar + '%' OR
            e.Apellido LIKE '%' + @buscar + '%' OR
            e.DNI LIKE '%' + @buscar + '%'
        GROUP BY
            e.IdEmpleado,
            e.Nombre,
            e.Apellido;
    END
    ELSE
    BEGIN
        -- Insertar faltas en la tabla Faltas
        INSERT INTO Falta (IdEmpleado, FechaFalta)
        SELECT
            e.IdEmpleado,
            @FechaActual
        FROM
            Empleado AS e
            LEFT JOIN Asistencia AS a ON e.IdEmpleado = a.IdEmpleado
                                    AND CONVERT(DATE, a.FechaAsistencia) = @FechaActual
        WHERE
            e.Nombre LIKE '%' + @buscar + '%' OR
            e.Apellido LIKE '%' + @buscar + '%' OR
            e.DNI LIKE '%' + @buscar + '%'
            AND a.FechaAsistencia IS NULL;

        -- Obtener resultados con el recuento de faltas
        SELECT
            e.IdEmpleado,
            e.Nombre,
            e.Apellido,
            COUNT(*) AS Falta
        FROM
            Empleado AS e
            INNER JOIN Falta AS f ON e.IdEmpleado = f.IdEmpleado
                                    AND f.FechaFalta = @FechaActual
        WHERE
            e.Nombre LIKE '%' + @buscar + '%' OR
            e.Apellido LIKE '%' + @buscar + '%' OR
            e.DNI LIKE '%' + @buscar + '%'
        GROUP BY
            e.IdEmpleado,
            e.Nombre,
            e.Apellido;
    END
END;

EXEC SP_ObtenerFaltasPorEmpleado @buscar = ''


CREATE PROCEDURE SP_BuscarAsistenciasPorDia
    @fecha DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        A.IdAsistencia,
        E.Nombre,
        E.Apellido,
        A.FechaAsistencia,
        A.HoraEntrada,
        A.HoraSalida
    FROM
        Asistencia AS A
        INNER JOIN Empleado AS E ON A.IdEmpleado = E.IdEmpleado
    WHERE
        A.FechaAsistencia = @fecha;
END;


EXEC SP_BuscarAsistenciasPorDia @fecha = '2023-06-30';


CREATE PROCEDURE SP_ObtenerFaltasPorFecha
    @fecha DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        e.IdEmpleado,
        e.Nombre,
        e.Apellido,
        ar.NombreArea,
        COUNT(*) AS Falta
    FROM
        Empleado AS e
        LEFT JOIN Asistencia AS a ON e.IdEmpleado = a.IdEmpleado
                                AND CONVERT(DATE, a.FechaAsistencia) = @fecha
        INNER JOIN Area AS ar ON e.IdArea = ar.IdArea
    WHERE
        a.FechaAsistencia IS NULL
    GROUP BY
        e.IdEmpleado,
        e.Nombre,
        e.Apellido,
        ar.NombreArea;
END;

EXEC SP_ObtenerFaltasPorFecha @fecha = '2023-06-30';

CREATE PROCEDURE SP_LoginUsuario
    @pusuario varchar(30),
    @ppassword varchar(100)
AS
BEGIN
    SELECT IdUsuario, Nombre, Nivel
    FROM Usuario
    WHERE Nombre = @pusuario AND Clave = @ppassword AND Nivel IN ('ADMINISTRADOR', 'PUESTODECONTROL')
END

EXEC SP_LoginUsuario @pusuario = 'admin', @ppassword = 'admin2023';

CREATE PROCEDURE SP_MarcarAsistencia
    @Nombre VARCHAR(100),
    @DNI VARCHAR(20)
AS
BEGIN
    -- Verificar si el empleado existe
    IF EXISTS (SELECT 1 FROM Empleado WHERE Nombre = @Nombre AND DNI = @DNI)
    BEGIN
        DECLARE @IdEmpleado INT;

        -- Obtener el IdEmpleado del empleado
        SELECT @IdEmpleado = IdEmpleado
        FROM Empleado
        WHERE Nombre = @Nombre AND DNI = @DNI;

        -- Verificar si el empleado ya ha marcado asistencia para el día actual
        IF NOT EXISTS (SELECT 1 FROM Asistencia WHERE IdEmpleado = @IdEmpleado AND FechaAsistencia = CONVERT(DATE, GETDATE()))
        BEGIN
            -- Insertar el registro de asistencia con fecha y hora actual
            INSERT INTO Asistencia (IdEmpleado, FechaAsistencia, HoraEntrada)
            VALUES (@IdEmpleado, CONVERT(DATE, GETDATE()), CONVERT(TIME, GETDATE()));

            -- Devolver un mensaje de éxito
            SELECT 'Asistencia marcada correctamente.' AS Mensaje;
        END
        ELSE
        BEGIN
            -- Devolver un mensaje de error si el empleado ya ha marcado asistencia para el día actual
            SELECT 'El empleado ya ha marcado asistencia para el día actual.' AS Mensaje;
        END
    END
    ELSE
    BEGIN
        -- Devolver un mensaje de error si el empleado no existe
        SELECT 'El empleado con Nombre ' + @Nombre + ' y DNI ' + @DNI + ' no fue encontrado.' AS Mensaje;
    END
END


EXEC SP_MarcarAsistencia @Nombre = 'David', @DNI = '12121212';