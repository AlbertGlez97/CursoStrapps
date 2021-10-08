-- Crear Base Datos
CREATE DATABASE Empleados;

-- Usar Base Datos
USE Empleados;

-- Crear Tabla
CREATE TABLE Persona(
	idPersona int NOT NULL,
	nombre varchar (50) NOT NULL,
	apellidoPaterno varchar (50) NOT NULL,
	apellidoMaterno varchar (50) NOT NULL,
	sexo char NOT NULL,
	curp varchar (15) NOT NULL,
	telefono varchar (15) NOT NULL,
	correoElectronico varchar (25) NOT NULL,
	fechaNacimineto datetime NOT NULL,
	nacionalidad varchar (50) NOT NULL,
);

-- Insertar Registros 
INSERT INTO Persona(idPersona ,nombre ,apellidoPaterno ,apellidoMaterno ,sexo ,curp ,telefono ,correoElectronico ,fechaNacimineto ,nacionalidad)
VALUES (1,'MARIA','LOPEZ','HERNANDEZ','F','XXXXXXX','XXXXXX','MARIA@CORREO.COM','1987-01-01','MEXICANA')

INSERT INTO Persona(idPersona ,nombre ,apellidoPaterno ,apellidoMaterno ,sexo ,curp ,telefono ,correoElectronico ,fechaNacimineto ,nacionalidad)
VALUES (2,'JORGE','LOPEZ','HERNANDEZ','M','XXXXXXX','XXXXXX','JORGE@CORREO.COM','1987-01-01','CHILENO')

-- Actualizar Registros
update Persona
SET nacionalidad = 'MEXICA'
WHERE nacionalidad = 'CHILENO' or nacionalidad ='COLOMBIANO'

-- Eliminar Tabla
DELETE
FROM Persona
Where idPersona=3

-- Crear Funcion

CREATE FUNCTION calcularEdad(@fechaNacimineto DATETIME)
RETURNS INT
AS
BEGIN
	RETURN 0
END
GO

SELECT *, dbo.calcularEdad(fechaNacimineto) AS edad FROM Persona