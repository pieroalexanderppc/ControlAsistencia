-- Vista Empleado con su departamento
CREATE VIEW V_Empleados_Area
AS
SELECT 
    e.IdEmpleado,
	a.NombreArea AS Area,
    e.Nombre,
    e.Apellido
FROM 
    Empleado AS e
INNER JOIN 
    Area AS a ON e.IdArea = a.IdArea;
GO

SELECT * FROM V_Empleados_Area;


-- Vista Tardanza por Mes por empleado
CREATE VIEW V_Tardanza_Mensual
AS
SELECT
    E.IdEmpleado,
    E.Nombre,
    E.Apellido,
    MONTH(A.FechaAsistencia) AS Mes,
    SUM(CASE WHEN A.HoraEntrada > H.HoraEntrada THEN DATEDIFF(MINUTE, H.HoraEntrada, A.HoraEntrada) ELSE 0 END) AS TardanzaEnMinutos
FROM
    Empleado AS E
    INNER JOIN Asistencia AS A ON E.IdEmpleado = A.IdEmpleado
    INNER JOIN Area AS AR ON E.IdArea = AR.IdArea
    INNER JOIN Horario AS H ON AR.IdHorario = H.IdHorario
        AND CONVERT(DATE, A.FechaAsistencia) BETWEEN H.FechaInicio AND H.FechaFin
GROUP BY
    E.IdEmpleado,
    E.Nombre,
    E.Apellido,
    MONTH(A.FechaAsistencia);
GO

SELECT * FROM V_Tardanza_Mensual;

-- Vista Faltas Mesual por Empleado
CREATE VIEW V_Faltas_Mensuales
AS
SELECT
    E.IdEmpleado,
    E.Nombre,
    E.Apellido,
    MONTH(F.FechaFalta) AS Mes,
    COUNT(*) AS Faltas
FROM
    Empleado AS E
    LEFT JOIN Falta AS F ON E.IdEmpleado = F.IdEmpleado
GROUP BY
    E.IdEmpleado,
    E.Nombre,
    E.Apellido,
    MONTH(F.FechaFalta);
GO

SELECT * FROM V_Faltas_Mensuales;