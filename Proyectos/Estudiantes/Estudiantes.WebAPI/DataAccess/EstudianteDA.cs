using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.WebAPI.DataAccess
{
    public class EstudianteDA
    {
        private readonly IConfiguration configuration;

        public EstudianteDA(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<Models.Estudiante> ObtenerEstudiantes()
        {
            List<Models.Estudiante> listaEstudiantes = new List<Models.Estudiante>();
            //Esta cadena de conexion , va a acceder a nuestro appsettings.Development.json
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var query = "SELECT idEstudiante,nombre,apellidoPaterno,apellidoMaterno,sexo,curp, " +
                            "fechaNacimiento,nacionalidad,telefono,correoElectronico,activo, " +
                            "idDireccion,calle,numeroInterior,numeroExterior,colonia, " +
                            "municipio,estado,codigoPostal,idDatosEscolares,numeroMatricula,carrera ,fechaIngreso ,semestre " +
                            "FROM Estudiante WHERE activo = 1";

                var resultado = db.Query(query).ToList();

                //Iteramos el resultado
                foreach (var elemento in resultado)
                {
                    Models.Estudiante empleado = new Models.Estudiante(elemento);
                    listaEstudiantes.Add(empleado);
                }
            }
            return listaEstudiantes;
        }

        public Models.Estudiante ObtenerPorIdEstudiante(int idEstudiante)
        {
            //1- Inicio
            Models.Estudiante estudiante = null;
            //2- Recibir el id Empleado
            //3- Obtener la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //5- Craer la consulta (query)
                string query = "SELECT idEstudiante,nombre,apellidoPaterno,apellidoMaterno,sexo,curp, " +
                                "fechaNacimiento,nacionalidad,telefono,correoElectronico,activo, " +
                                "idDireccion,calle,numeroInterior,numeroExterior,colonia, " +
                                "municipio,estado,codigoPostal,idDatosEscolares,numeroMatricula,carrera ,fechaIngreso ,semestre " +
                                "FROM Estudiante WHERE idEstudiante = @idEstudiante";

                //6- Ejecutar la consulta
                var resultado = db.QueryFirstOrDefault(query, new { idEstudiante = idEstudiante });

                //7-Validar y Crear un objeto modelo con la informacion de la base de datos (Dapper)
                if (resultado != null)
                {
                    estudiante = new Models.Estudiante(resultado);
                }
                else
                {
                    estudiante = null;
                }
            }
            return estudiante;
        }

        public Models.Estudiante Crear(Models.Estudiante estudiante)
        {
            //1- Inicio
            int idEstudiante;
            //2- Obtner la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //3- Crear Conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //4- Crear el query para insertar
                string query = "INSERT INTO Estudiante(nombre,apellidoPaterno,apellidoMaterno,sexo,curp, " +
                               "fechaNacimiento,nacionalidad,telefono,correoElectronico,activo, " +
                               "idDireccion,calle,numeroInterior,numeroExterior,colonia, " +
                               "municipio,estado,codigoPostal,idDatosEscolares,numeroMatricula,carrera ,fechaIngreso ,semestre ) " +
                               "VALUES (@nombre,@apellidoPaterno,@apellidoMaterno,@sexo,@curp, " +
                               "@fechaNacimiento,@nacionalidad,@telefono,@correoElectronico,@activo, " +
                               "@idDireccion,@calle,@numeroInterior,@numeroExterior,@colonia, " +
                               "@municipio,@estado,@codigoPostal,@idDatosEscolares,@numeroMatricula,@carrera ,@fechaIngreso ,@semestre ) " +
                               "SELECT CAST(SCOPE_IDENTITY() as int) AS idEstudiante";

                var parametros = estudiante.ObtenerParametros();

                //5- Ejcutar la consulta (query)
                idEstudiante = db.QuerySingle<int>(query, parametros);
                //6- Ejecutar la consulta para obtner el empleado
                //7- Crea el objeto empleado de Models

                // Alternativa 
                estudiante.IdEstudiante = idEstudiante;
            }
            //8- Retornar el empleado de Models
            return estudiante;
        }

        public Models.Estudiante Actualizar(Models.Estudiante estudiante)
        {
            //1- Inicio
            //2- Recibir el empleado actualizar
            //3- Obtner cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {

                //5- Crear el query para actualizar
                string query = "UPDATE Estudiante SET nombre = @nombre,apellidoPaterno = @apellidoPaterno,apellidoMaterno = @apellidoMaterno,sexo = @sexo,curp = @curp, " +
                               "fechaNacimiento = @fechaNacimiento,nacionalidad = @nacionalidad,telefono = @telefono,correoElectronico = @correoElectronico,activo = @activo, " +
                               "idDireccion = @idDireccion,calle = @calle,numeroInterior = @numeroInterior,numeroExterior = @numeroExterior,colonia = @colonia, " +
                               "municipio = @municipio,estado = @estado,codigoPostal = @codigoPostal,idDatosEscolares = @idDatosEscolares,numeroMatricula = @numeroMatricula, " +
                               "carrera = @carrera ,fechaIngreso = @fechaIngreso ,semestre = @semestre " +
                               "WHERE idEstudiante = @idEstudiante";

                var parametros = estudiante.ObtenerParametros();

                //6- Ejecutar el query de actualizar
                int numRegistroAfectados = db.Execute(query, parametros);


            }

            return estudiante;
        }


    }
}
