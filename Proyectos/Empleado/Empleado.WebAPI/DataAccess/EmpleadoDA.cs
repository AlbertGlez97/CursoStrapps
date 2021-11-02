using System;
using Models = Empleado.WebAPI.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Empleado.WebAPI.DataAccess
{
    public class EmpleadoDA
    {
        private readonly IConfiguration configuration;
        public EmpleadoDA(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public List<Models.Empleado> ObtenerEmpleados()
        {
            List<Models.Empleado> listaEmpleados = new List<Models.Empleado>();
            //Esta cadena de conexion , va a acceder a nuestro appsettings.Development.json
            string cadenaConexion = configuration.GetConnectionString("EmpleadoConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var query = "SELECT idEmpleado,idPersona,nombre,apellidoPaterno,apellidoMaterno," +
                                "sexo,curp,telefono,correoElectronico,fechaNacimiento," +
                                "nacionalidad,idDireccion,calle,numeroExterior,numeroInterior," +
                                "colonia,municipio,estado,codigoPostal,RFC,puesto,fechaIngreso," +
                                "salarioDiario,NSS,horario,totalFaltas,activo  " +
                            "FROM Empleado WHERE activo = 1";

                var resultado = db.Query(query).ToList();

                //Iteramos el resultado
                foreach (var elemento in resultado)
                {
                    Models.Empleado empleado = new Models.Empleado(elemento);
                    listaEmpleados.Add(empleado);
                }
            }
            return listaEmpleados;
        }

        public Models.Empleado Crear(Models.Empleado empleado)
        {
            //1- Inicio
            int idEmpleado;
            //2- Obtner la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EmpleadoConnection");

            //3- Crear Conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //4- Crear el query para insertar
                string query = "INSERT INTO Empleado (idPersona,nombre,apellidoPaterno,apellidoMaterno,sexo,curp,telefono, " +
                               "correoElectronico,fechaNacimiento,nacionalidad,idDireccion,calle, " +
                               "numeroExterior,numeroInterior,colonia,municipio,estado,codigoPostal, " +
                               "RFC,puesto,fechaIngreso,salarioDiario,NSS,horario,totalFaltas,activo) " +
                               "VALUES (@idPersona, @nombre,@apellidoPaterno, @apellidoMaterno, @sexo,@curp, @telefono, @correoElectronico, " +
                               "@fechaNacimiento,@nacionalidad,@idDireccion,@calle,@numeroExterior, @numeroInterior, @colonia, " +
                               "@municipio, @estado, @codigoPostal, @RFC, @puesto, @fechaIngreso, @salarioDiario, @NSS,@horario, " +
                               "@totalFaltas, @activo) " +
                               "SELECT CAST(SCOPE_IDENTITY() as int) AS idEmpleado";

            var parametros = empleado.ObtenerParametros();    

            //5- Ejcutar la consulta (query)
                idEmpleado = db.QuerySingle<int>(query,parametros);
                //6- Ejecutar la consulta para obtner el empleado
                //7- Crea el objeto empleado de Models

                // Alternativa 
                empleado.idEmpleado = idEmpleado;
            }
            //8- Retornar el empleado de Models
            return empleado;
        }

        public Models.Empleado Obtener(int idEmpleado)
        {
            //1- Inicio
            Models.Empleado empleado = null;
            //2- Recibir el id Empleado
            //3- Obtener la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EmpleadoConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
            //5- Craer la consulta (query)
            string query = "SELECT idEmpleado,idPersona,nombre,apellidoPaterno,apellidoMaterno, "+
                            "sexo,curp,telefono,correoElectronico,fechaNacimiento, "+
                            "nacionalidad,idDireccion,calle,numeroExterior,numeroInterior, "+
                            "colonia,municipio,estado,codigoPostal,RFC,puesto,fechaIngreso, "+
                            "salarioDiario,NSS,horario,totalFaltas,activo "+
                            "FROM Empleado WHERE idEmpleado = @idEmpleado"; 
            
            //6- Ejecutar la consulta
            var resultado = db.QueryFirstOrDefault(query, new {idEmpleado = idEmpleado});

            //7-Validar y Crear un objeto modelo con la informacion de la base de datos (Dapper)
            if(resultado !=null)
            {
                empleado = new Models.Empleado(resultado);
            }
            else
            {
                empleado= null;
            }
            }
            return empleado;
        }

        public Models.Empleado Actualizar(Models.Empleado empleado)
        {
            //1- Inicio
            //2- Recibir el empleado actualizar
            //3- Obtner cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EmpleadoConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {

            //5- Crear el query para actualizar
            string query =  "UPDATE Empleado "+
                            "SET idPersona=@idPersona,nombre=@nombre, apellidoPaterno=@apellidoPaterno, apellidoMaterno=@apellidoMaterno, sexo=@sexo, curp=@curp, telefono=@telefono, correoElectronico=@correoElectronico, " +
                            "fechaNacimiento=@fechaNacimiento, nacionalidad=@nacionalidad, idDireccion=@idDireccion, calle=@calle,numeroExterior=@numeroExterior, numeroInterior=@numeroInterior, colonia=@colonia, " +
                            "municipio=@municipio, estado=@estado, codigoPostal=@codigoPostal, RFC=@RFC, puesto=@puesto, fechaIngreso=@fechaIngreso, salarioDiario=@salarioDiario, NSS=@NSS, horario=@horario, " +
                            "totalFaltas=@totalFaltas, activo=@activo "+
                            "WHERE idEmpleado= @idEmpleado";

            var parametros = empleado.ObtenerParametros();

            //6- Ejecutar el query de actualizar
            int numRegistroAfectados = db.Execute(query,parametros);
            

            }

            return empleado;
        }
        
    }
}