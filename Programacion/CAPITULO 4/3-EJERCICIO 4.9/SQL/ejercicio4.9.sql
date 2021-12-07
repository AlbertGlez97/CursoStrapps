CREATE DATABASE EJEMPLO_4_9
GO

USE EJEMPLO_4_9
GO

CREATE TABLE CALENDARIO
(
    fecha DATETIME PRIMARY KEY,
    ndia INT,
    nMes INT,
    nAnio INT,
    VDia VARCHAR(20),
    vMes VARCHAR(20)
)
GO

-- LLENAR LOS DATOS
DECLARE @fechaInicial DATETIME = '2021-01-01'
DECLARE @fechaFinal DATETIME = '2021-12-31'
PRINT CONVERT(VARCHAR(20), @fechaInicial,103)

WHILE @fechaInicial <= @fechaFinal
BEGIN
    INSERT CALENDARIO(fecha) VALUES(@fechaInicial)
    SET @fechaInicial = DATEADD(day,1,@fechaInicial)
    PRINT CONVERT(VARCHAR(20), @fechaInicial,103)
END

SET LANGUAGE Spanish

SELECT fecha,
       DATEPART(WEEKDAY, fecha) AS nDia,
       DATEPART(MONTH, fecha) AS nMes,
       DATEPART(YEAR, fecha) AS nAnio,
       CASE DATEPART(WEEKDAY, fecha)
            WHEN 7 THEN 'DOMINGO'
            WHEN 1 THEN 'LUNES'
            WHEN 2 THEN 'MARTES'
            WHEN 3 THEN 'MIERCOLES'
            WHEN 4 THEN 'JUEVES'
            WHEN 5 THEN 'VIERNES'
            WHEN 6 THEN 'SABADO'
            ELSE 'DIA NO VALIDO'
       END AS vDia,
       CASE
            WHEN DATEPART(MONTH, fecha) =1 THEN 'ENERO'
            WHEN DATEPART(MONTH, fecha) =2 THEN 'FEBRERO'
            WHEN DATEPART(MONTH, fecha) =3 THEN 'MARZO'
            WHEN DATEPART(MONTH, fecha) =4 THEN 'ABRIL'
            WHEN DATEPART(MONTH, fecha) =5 THEN 'MAYO'
            WHEN DATEPART(MONTH, fecha) =6 THEN 'JUNIO'
            WHEN DATEPART(MONTH, fecha) =7 THEN 'JULIO'
            WHEN DATEPART(MONTH, fecha) =8 THEN 'AGOSTO'
            WHEN DATEPART(MONTH, fecha) =9 THEN 'SEPTIEMBRE'
            WHEN DATEPART(MONTH, fecha) =10 THEN 'OCTUBRE'
            WHEN DATEPART(MONTH, fecha) =11 THEN 'NOVIEMBRE'
            WHEN DATEPART(MONTH, fecha) =12 THEN 'DICIEMBRE'
            ELSE 'DIA NO VALIDO'
        END AS vMes,
        DATETIME(WEEKDAY,fecha) AS vDia,
        DATETIME(MONTH,fecha) AS vMes2,
FROM CALENDARIO

UPDATE CALENDARIO
SET     nDia = DATEPART(WEEKDAY,fecha)
        nMes = DATEPART(MONTH,fecha),
        nAnio = DATEPART(YEAR, fecha)
        vDia = CASE DATEPART(WEEKDAY, fecha)
            WHEN 7 THEN 'DOMINGO'
            WHEN 1 THEN 'LUNES'
            WHEN 2 THEN 'MARTES'
            WHEN 3 THEN 'MIERCOLES'
            WHEN 4 THEN 'JUEVES'
            WHEN 5 THEN 'VIERNES'
            WHEN 6 THEN 'SABADO'
            ELSE 'DIA NO VALIDO'
        END,
        vMes = CASE DATEPART(MONTH,fecha)
            WHEN DATEPART(MONTH, fecha) =1 THEN 'ENERO'
            WHEN DATEPART(MONTH, fecha) =2 THEN 'FEBRERO'
            WHEN DATEPART(MONTH, fecha) =3 THEN 'MARZO'
            WHEN DATEPART(MONTH, fecha) =4 THEN 'ABRIL'
            WHEN DATEPART(MONTH, fecha) =5 THEN 'MAYO'
            WHEN DATEPART(MONTH, fecha) =6 THEN 'JUNIO'
            WHEN DATEPART(MONTH, fecha) =7 THEN 'JULIO'
            WHEN DATEPART(MONTH, fecha) =8 THEN 'AGOSTO'
            WHEN DATEPART(MONTH, fecha) =9 THEN 'SEPTIEMBRE'
            WHEN DATEPART(MONTH, fecha) =10 THEN 'OCTUBRE'
            WHEN DATEPART(MONTH, fecha) =11 THEN 'NOVIEMBRE'
            WHEN DATEPART(MONTH, fecha) =12 THEN 'DICIEMBRE'
            ELSE 'DIA NO VALIDO'
        END

