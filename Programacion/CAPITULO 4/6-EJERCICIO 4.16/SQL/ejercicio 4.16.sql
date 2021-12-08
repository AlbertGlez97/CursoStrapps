CREATE DATABASE EJERCICIO_4_16
GO

USE EJERCICIO_4_16
GO

CREATE TABLE valoresABC
(
ID INT IDENTITY(1,1) NOT NULL,
A INT,
B INT,
C INT,
MAYOR VARCHAR(100),
MENOR VARCHAR(100)
)

INSERT INTO valoresABC(A,B,C) VALUES(1,2,3)
INSERT INTO valoresABC(A,B,C) VALUES(2,1,3)
INSERT INTO valoresABC(A,B,C) VALUES(2,3,1)
INSERT INTO valoresABC(A,B,C) VALUES(3,2,1)
INSERT INTO valoresABC(A,B,C) VALUES(3,1,2)
INSERT INTO valoresABC(A,B,C) VALUES(1,3,2)


SELECT * FROM valoresABC
GO

CREATE FUNCTION DBO.MINIMO(@A INT,@B INT,@C INT)
RETURNS VARCHAR
AS
BEGIN
--3.- Validar si A  > B
            if (@A > @B)
            BEGIN
                --3.1.- Si A es mayor, validar A < C
                if (@A > @C)
                BEGIN
                    --3.1.2.- Si A es mayor, validar B < C
                    if (@B < @C)
                    BEGIN
                        --3.1.2.1.- Si B es menor, EL MAXIMO ES A Y EL MINIMO ES B
                        Console.WriteLine("EL MAXIMO ES A");
                        Console.WriteLine("EL MINIMO ES B");
                    END
                    ELSE
                    BEGIN
                        --3.1.2.2.- Si B no es menor, EL MAXIMO ES A Y EL MINIMO ES C
                        Console.WriteLine("EL MAXIMO ES A");
                        Console.WriteLine("EL MINIMO ES C");
                    END
                END
                else
                BEGIN
                    --3.1.3.- Si A no es mayor, EL MAXIMO ES C Y EL MINIMO ES B
                    Console.WriteLine("EL MAXIMO ES C");
                    Console.WriteLine("EL MINIMO ES B");
                END

            END
            else
            BEGIN
                --3.2.- Si A no es mayor, validar si B > C
                if (@B > @C)
                BEGIN
                    --3.2.1.- Si B es mayor, Validar A < C
                    if (@A < @C)
                    BEGIN
                        --3.2.1.1.- Si A es menor, EL MAXIMO ES B Y EL MINIMO ES A
                        Console.WriteLine("EL MAXIMO ES B");
                        Console.WriteLine("EL MINIMO ES A");
                    END
                    else
                    BEGIN
                        --3.2.1.2.- Si A no es menor, El MAXIMO ES B Y EL MINIMO ES C
                        Console.WriteLine("EL MAXIMO ES B");
                        Console.WriteLine("EL MINIMO ES C");
                    END
                END
                else
                BEGIN
                    --3.2.2.- Si B no es mayor, EL MAXIMO ES C Y EL MINIMO ES A
                    Console.WriteLine("EL MAXIMO ES C");
                    Console.WriteLine("EL MINIMO ES A");
                END
            END
            --4.- Fin  											
  
END
GO