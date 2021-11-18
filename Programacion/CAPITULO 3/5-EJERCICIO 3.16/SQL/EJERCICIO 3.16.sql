CREATE DATABASE EJERCICIO_3_16
GO

USE EJERCICIO_3_16
GO

CREATE TABLE FACTORIAL
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	RESULTADO INT,
	FECHA_ALTA DATETIME,
	FECHA_CALCULO DATETIME
)
GO

INSERT INTO FACTORIAL(RESULTADO,FECHA_ALTA,FECHA_CALCULO) VALUES(NULL,GETDATE(),NULL)
INSERT INTO FACTORIAL(RESULTADO,FECHA_ALTA,FECHA_CALCULO) VALUES(NULL,GETDATE(),NULL)
INSERT INTO FACTORIAL(RESULTADO,FECHA_ALTA,FECHA_CALCULO) VALUES(NULL,GETDATE(),NULL)
INSERT INTO FACTORIAL(RESULTADO,FECHA_ALTA,FECHA_CALCULO) VALUES(NULL,GETDATE(),NULL)
INSERT INTO FACTORIAL(RESULTADO,FECHA_ALTA,FECHA_CALCULO) VALUES(NULL,GETDATE(),NULL)

SELECT * FROM FACTORIAL

GO

ALTER PROCEDURE SP_FACTORIAL_ACTUALIZA
AS
BEGIN
	DECLARE @ID INT
	DECLARE @IDMAX INT
	DECLARE @RESULTADO INT
	SET @ID = 1
	SET @IDMAX = (SELECT MAX(ID) FROM FACTORIAL)

	WHILE @ID <= @IDMAX
	BEGIN
		SET @RESULTADO = DBO.CALCULOFACTORIAL(@ID)

		UPDATE FACTORIAL 
		SET RESULTADO = @RESULTADO,
			FECHA_CALCULO = GETDATE()
		WHERE ID= @ID

		PRINT '@id' + CONVERT(VARCHAR,@ID)
		PRINT '@RESULTADO' + CONVERT(VARCHAR,@RESULTADO)

		SET @ID = @ID + 1
	END
END
GO

CREATE FUNCTION DBO.CALCULOFACTORIAL(@ID INT)
RETURNS INT
AS
BEGIN
			--3.16 Escribir un algoritmo que calcule el producto de los n primeros numeros naturales
           -- Analisis, el problema puede calcular el producto N * (N - 1) * (N* -2) * ...... * 3 * 2 * 1, que en terminos matematicos se le conoce con el nombre de FACTORIAL
           --1.- Inicio                 
           --2.- Leer el valor de N                     -> N =6
		   --3.- Declarar e inicializar contador = 2    -> N =6, contador =2
			DECLARE @contador INT
			SET @contador=2 
		   --4.- Declarar e inicializar factorial = 1   -> N =6, contador =2,factorial =1
            DECLARE @factorial INT
			SET @factorial=1 
		   --5.- Iterar mientras contador <= N
		   WHILE @contador <= @ID
		  BEGIN
                --5.1 Calcular el factorial, factorial = factorial * contador   ->N=6 ,contador =5, factorial=24 * = 120
                SET @factorial = @factorial * @contador
				--5.2 Incrementar contador en 1, contador = contador + 1        ->N=6 ,contador =6, factorial=120
                SET @contador = @contador + 1
		   END
		   --6.- Imprimir el resultado 
		   RETURN @factorial;
           --7.- Fin
END
GO

SELECT * FROM FACTORIAL

EXEC SP_FACTORIAL_ACTUALIZA