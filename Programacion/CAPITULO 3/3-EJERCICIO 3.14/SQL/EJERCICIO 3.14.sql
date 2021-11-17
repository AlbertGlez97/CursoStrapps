CREATE DATABASE EJERCICIO_3_14
GO

USE EJERCICIO_3_14
GO

CREATE TABLE LLAMADAS
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	DURACION INT NOT NULL,
	COSTO_LLAMADA INT,
	COSTO_EXCCEDENTE INT,
	TOTAL_PAGAR INT,
	FECHA_ALTA DATETIME
)
GO

--DECLARACIONES
DECLARE @DURACION INT
DECLARE @COSTO_LLAMADA INT
DECLARE @TOTAL_PAGAR INT
DECLARE @COSTO_EXCEDENTE INT
DECLARE @FECHA_ALTA DATETIME

--ASIGNACIONES
SET @DURACION = 10 --10 MINUTOS
SET @COSTO_LLAMADA = 10 -- LOS PRIMEROS 3 MINUTOS
SET @TOTAL_PAGAR = DBO.GET_COSTO_EXCEDENTE(@DURACION)
SET @COSTO_EXCEDENTE=@TOTAL_PAGAR - @COSTO_LLAMADA
SET @FECHA_ALTA = GETDATE()

INSERT INTO LLAMADAS(DURACION,COSTO_LLAMADA,COSTO_EXCCEDENTE,TOTAL_PAGAR,FECHA_ALTA)
VALUES(@DURACION,@COSTO_LLAMADA,@COSTO_EXCEDENTE,@TOTAL_PAGAR,@FECHA_ALTA)

SELECT * FROM LLAMADAS

GO

CREATE FUNCTION DBO.GET_COSTO_EXCEDENTE(@DURACION INT)
RETURNS INT
AS
BEGIN
			--1.- Inicio
            --2.- Leer la duracion de la llamada y asignarla a duracion
            --3.- Declarar variables totalPagar , resto
			DECLARE @totalPagar INT
			DECLARE @resto INT
            --4.- Asignar totalPagar = 10
			SET @totalPagar = 10
            --5.- Valida si la duracion es mayor a 3 minutos
			IF @DURACION > 3
			BEGIN
                --5.1.- Si la duracion es mayor a 3 minutos
                    --resto = duracion - 3
					SET @resto = @DURACION - 3
                    -- totalPagar = totalPagar + resto * S
					SET @totalPagar = @totalPagar + @resto * 5
            END
			--6.- El totla a pagar es totalPagar
			RETURN @totalPagar;
            --7.- Fin
END