CREATE DATABASE Estudiantes

DROP DATABASE Estudiantes
go

use Estudiantes
go


Create table Estudiante(
idEstudiante int IDENTITY(1,1) PRIMARY KEY,
nombre varchar(100) not null,
apellidoPaterno varchar(100) not null,
apellidoMaterno varchar(100) not null,
sexo char not null,
curp varchar(100) not null,
fechaNacimiento date not null,
nacionalidad varchar(100) not null,
telefono varchar(100) not null,
correoElectronico varchar(100) not null,
activo bit not null,
idDireccion int,
calle varchar(100) not null,
numeroInterior varchar(100) not null,
numeroExterior varchar(100) not null,
colonia varchar(100) not null,
municipio varchar(100) not null,
estado varchar(100) not null,
codigoPostal int not null,
idDatosEscolares int not null,
numeroMatricula bigint not null,
carrera varchar(100) not null,
fechaIngreso date not null,
semestre varchar(100) not null,
);

INSERT INTO Estudiante(nombre,apellidoPaterno,apellidoMaterno,sexo,curp,
			fechaNacimiento,nacionalidad,telefono,correoElectronico,activo,
			idDireccion,calle,numeroInterior,numeroExterior,colonia,
			municipio,estado,codigoPostal,idDatosEscolares,numeroMatricula,carrera ,fechaIngreso ,semestre )
VALUES ('Juan Alberto','Gonzalez','Cruz','M','GOCJ97020997','2021-10-2','Mexicana',
			 '55-66-89-59','juan.alberto@hotmail.com',1,1,'Gustavo Diaz Ordaz',
			 '25-b','25','Roma Norte','Coyoacan','Mexico',558869,1,0171025,'Sistemas','2021-10-2','6to Semestre');

SELECT idEstudiante,nombre,apellidoPaterno,apellidoMaterno,sexo,curp,
fechaNacimiento,nacionalidad,telefono,correoElectronico,activo,
idDireccion,calle,numeroInterior,numeroExterior,colonia,
municipio,estado,codigoPostal,idDatosEscolares,numeroMatricula,carrera ,fechaIngreso ,semestre
FROM Estudiante WHERE activo = 1


Create table MateriasCursando(
idMateriasCursando int IDENTITY(1,1) PRIMARY KEY,
claveMateria bigint not null,
materia varchar(100) not null,
horario varchar(100) not null,
calificacionUno float not null,
calificacionDos float not null,
calificacionTres float not null,
activo bit not null,
idEstudiante int not null,
CONSTRAINT fk_EstudianteCursando FOREIGN KEY (idEstudiante) REFERENCES Estudiante (idEstudiante)
);

INSERT INTO MateriasCursando (claveMateria,materia ,horario ,calificacionUno ,calificacionDos,
calificacionTres,activo ,idEstudiante) 
VALUES (834833,'JavaScript','10am - 12am',8.5,9.2,8.9,1,2);

SELECT idMateriasCursando,claveMateria,materia ,horario ,calificacionUno ,calificacionDos,
calificacionTres,activo ,idEstudiante
FROM MateriasCursando WHERE MateriasCursando.activo=1 


Create table MateriasCursadas(
idMateriasCursadas int IDENTITY(1,1) PRIMARY KEY,
claveMateria bigint not null,
materia varchar(100) not null,
calificacionUno float not null,
calificacionDos float not null,
calificacionTres float not null,
calificacionFinal float not null,
activo bit not null,
idEstudiante int not null,
CONSTRAINT fk_EstudianteCursadas FOREIGN KEY (idEstudiante) REFERENCES Estudiante (idEstudiante)
);

INSERT INTO MateriasCursadas (claveMateria,materia,calificacionUno ,calificacionDos,
calificacionTres,calificacionFinal,activo ,idEstudiante) 
VALUES (834833,'HTML',8.5,9.2,8.9,9.5,1,2);

SELECT idMateriasCursadas,claveMateria,materia,calificacionUno ,calificacionDos,
calificacionTres,calificacionFinal,activo ,idEstudiante
FROM MateriasCursadas WHERE MateriasCursadas.activo=1 

//*Obtener por id de Estudiante*/

SELECT idEstudiante,nombre,apellidoPaterno,apellidoMaterno,sexo,curp,
fechaNacimiento,nacionalidad,telefono,correoElectronico,activo,
idDireccion,calle,numeroInterior,numeroExterior,colonia,
municipio,estado,codigoPostal,idDatosEscolares,numeroMatricula,carrera ,fechaIngreso ,semestre
FROM Estudiante WHERE idEstudiante = 1

SELECT idMateriasCursando,claveMateria,materia ,horario ,calificacionUno ,calificacionDos,
calificacionTres,activo ,idEstudiante
FROM MateriasCursando WHERE idEstudiante = 1

SELECT idMateriasCursadas,claveMateria,materia,calificacionUno ,calificacionDos,
calificacionTres,calificacionFinal,activo ,idEstudiante
FROM MateriasCursadas WHERE idEstudiante = 1

//*Crear por id de Estudiante*/
INSERT INTO Estudiante(nombre,apellidoPaterno,apellidoMaterno,sexo,curp,
			fechaNacimiento,nacionalidad,telefono,correoElectronico,activo,
			idDireccion,calle,numeroInterior,numeroExterior,colonia,
			municipio,estado,codigoPostal,idDatosEscolares,numeroMatricula,carrera ,fechaIngreso ,semestre )
VALUES ('Juan Alberto','Gonzalez','Cruz','M','GOCJ97020997','2021-10-2','Mexicana',
			 '55-66-89-59','juan.alberto@hotmail.com',1,1,'Gustavo Diaz Ordaz',
			 '25-b','25','Roma Norte','Coyoacan','Mexico',558869,1,0171025,'Sistemas','2021-10-2','6to Semestre');
VALUES (@nombre,@apellidoPaterno,@apellidoMaterno,@sexo,@curp,
			@fechaNacimiento,@nacionalidad,@telefono,@correoElectronico,@activo,
			@idDireccion,@calle,@numeroInterior,@numeroExterior,@colonia,
			@municipio,@estado,@codigoPostal,@idDatosEscolares,@numeroMatricula,@carrera ,@fechaIngreso ,@semestre )

INSERT INTO MateriasCursando(claveMateria,materia ,horario ,calificacionUno ,calificacionDos,
calificacionTres,activo ,idEstudiante)
VALUES (@claveMateria,@materia ,@horario ,@calificacionUno ,@calificacionDos,
@calificacionTres,@activo ,@idEstudiante)
idMateriasCursando


/*Actualizar */
UPDATE Estudiante SET nombre=@nombre,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,sexo=@sexo,curp=@curp,
fechaNacimiento=@fechaNacimiento,nacionalidad=@nacionalidad,telefono=@telefono,correoElectronico=@correoElectronico,activo=@activo,
idDireccion=@idDireccion,calle=@calle,numeroInterior=@numeroInterior,numeroExterior=@numeroExterior,colonia=@colonia,
municipio=@municipio,estado=@estado,codigoPostal=@codigoPostal,idDatosEscolares=@idDatosEscolares,numeroMatricula=@numeroMatricula,
carrera=@carrera ,fechaIngreso=@fechaIngreso ,semestre=@semestre 
WHERE idEstudiante=@idEstudiante 

UPDATE MateriasCursando SET claveMateria=@claveMateria,materia=@materia ,horario=@horario ,calificacionUno=@calificacionUno ,calificacionDos=@calificacionDos,
calificacionTres=@calificacionTres,activo=@activo ,idEstudiante=@idEstudiante
WHERE idMateriasCursando=@idMateriasCursando











SELECT idMateriasCursando,claveMateria,materia ,horario ,calificacionUno ,calificacionDos, 
calificacionTres,activo ,idEstudiante 
FROM MateriasCursando WHERE idEstudiante = 1