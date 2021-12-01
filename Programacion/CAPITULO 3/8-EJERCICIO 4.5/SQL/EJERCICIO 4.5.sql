use EJERCICIO_4_5

go

CREATE TABLE EMPLEADO
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE VARCHAR(200),
	HORAS_TRABAJADAS INT,
	TARIFA_HORARIA INT,
	SALARIO_NETO DECIMAL(6,2)
)

GO

INSERT EMPLEADO(NOMBRE,HORAS_TRABAJADAS,TARIFA_HORARIA) 
VALUES ('ALBERTO',56,35)

INSERT EMPLEADO(NOMBRE,HORAS_TRABAJADAS,TARIFA_HORARIA) 
VALUES ('JOSE',35,60)

SELECT * FROM EMPLEADO

GO

CREATE FUNCTION DBO.SALARIONETO(@HORAS_TRABAJADAS INT,@TARIFA_HORARIA INT)
RETURNS DECIMAL
AS
BEGIN
	-- 1. Inicio
	DECLARE @salario_bruto DECIMAL
	DECLARE @impuestos DECIMAL
	DECLARE @salario_neto DECIMAL
	
	-- 3. Verificar si horas trabajadas <= 35, en cuyo caso
   if @HORAS_TRABAJADAS <= 35
   begin
			-- 3.1 Salario_bruto = horas * tarifa; en caso contrario
			set @salario_bruto = @HORAS_TRABAJADAS * @TARIFA_HORARIA
   end
   else
   begin
			-- 3.2 salario_bruto = 35 * tarifa + (horas - 35) * tarifa
			set @salario_bruto = 35 * @TARIFA_HORARIA + (@HORAS_TRABAJADAS - 35) * @TARIFA_HORARIA												
   end
														
   -- 4. Calculo de impuestos
   if @salario_bruto <= 2000 
   begin
			set @impuestos = 0;
   end
   -- 4.2 Si salario_bruto <= 2.220, entonces
   else if @salario_bruto <= 2220
   begin
	    -- 	impuestos = (salario_bruto - 2.000) * 0.20
		set @impuestos = (@salario_bruto - 2000) * 0.2;
   end
   -- 4.3 Si salario_bruto > 2.220 entonces
  else
  begin
  	    -- 	impuestos = (salario_bruto - 2.220) * 0.30 + (220 * 0.20)
  	   set @impuestos = (@salario_bruto - 2220) * 0.3 + 220 * 0.2;
  end

  -- 5. Calculo del salario_neto
  -- 	salaraio_neto = salario_bruto - impuestos
  set @salario_neto = @salario_bruto - @impuestos;

   RETURN @salario_neto
END
GO

--Actualizar con funciones ya definidas
UPDATE EMPLEADO
SET SALARIO_NETO = DBO.SALARIONETO(HORAS_TRABAJADAS,TARIFA_HORARIA)
GO

SELECT * FROM EMPLEADO