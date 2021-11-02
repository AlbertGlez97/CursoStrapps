using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Models = Estudiantes.WebAPI.Models;

namespace Estudiantes.WebAPI.DataAccess
{
    public class MateriasCursadasDA
    {
        private readonly IConfiguration configuration;

        public MateriasCursadasDA(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<Models.MateriasCursadas> ObtenerMateriasCursadasDA()
        {
            List<Models.MateriasCursadas> materiasCursadas = new List<Models.MateriasCursadas>();
            //Esta cadena de conexion , va a acceder a nuestro appsettings.Development.json
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var query = "SELECT idMateriasCursadas,claveMateria,materia,calificacionUno ,calificacionDos," +
                                "calificacionTres,calificacionFinal,activo ,idEstudiante " +
                            "FROM MateriasCursadas WHERE activo=1";

                var resultado = db.Query(query).ToList();

                //Iteramos el resultado
                foreach (var elemento in resultado)
                {
                    Models.MateriasCursadas materias = new Models.MateriasCursadas(elemento);
                    materiasCursadas.Add(materias);
                }
            }
            return materiasCursadas;
        }


        public Models.MateriasCursadas ObtenerPorIdMateria(int idMateriasCursadas)
        {
            //1- Inicio
            Models.MateriasCursadas materiasCursando = null;
            //2- Recibir el id Empleado
            //3- Obtener la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //5- Craer la consulta (query)
                string query = "SELECT idMateriasCursadas,claveMateria,materia,calificacionUno ,calificacionDos, " +
                               "calificacionTres,calificacionFinal,activo ,idEstudiante " +
                               "FROM MateriasCursadas WHERE activo=1 AND idMateriasCursadas = @idMateriasCursadas";

                //6- Ejecutar la consulta
                var resultado = db.QueryFirstOrDefault(query, new { idMateriasCursadas = idMateriasCursadas });

                //7-Validar y Crear un objeto modelo con la informacion de la base de datos (Dapper)
                if (resultado != null)
                {
                    materiasCursando = new Models.MateriasCursadas(resultado);
                }
                else
                {
                    materiasCursando = null;
                }
            }
            return materiasCursando;
        }

        public List<Models.MateriasCursadas> ObtenerPorIdAlumnos(int idEstudiante)
        {
            //1- Inicio
            List<Models.MateriasCursadas> listaMateriasCursadas = new List<Models.MateriasCursadas>();
            //2- Recibir el id Empleado
            //3- Obtener la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //5- Craer la consulta (query)
                string query = "SELECT idMateriasCursadas,claveMateria,materia,calificacionUno ,calificacionDos, " +
                               "calificacionTres,calificacionFinal,activo ,idEstudiante " +
                               "FROM MateriasCursadas WHERE activo=1 AND idEstudiante =" + idEstudiante;

                //6- Ejecutar la consulta
                var resultado = db.Query(query).ToList();

                //7-Validar y Crear un objeto modelo con la informacion de la base de datos (Dapper)
                foreach (var elemento in resultado)
                {
                    Models.MateriasCursadas materias = new Models.MateriasCursadas(elemento);
                    listaMateriasCursadas.Add(materias);
                }
            }
            return listaMateriasCursadas;
        }


        public Models.MateriasCursadas Crear(Models.MateriasCursadas materias)
        {
            //1- Inicio
            int idMaterias;
            //2- Obtner la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //3- Crear Conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //4- Crear el query para insertar
                string query = "INSERT INTO MateriasCursadas(claveMateria,materia ,calificacionUno ,calificacionDos, " +
                               "calificacionTres,calificacionFinal,activo ,idEstudiante) " +
                               "VALUES (@claveMateria,@materia ,@calificacionUno ,@calificacionDos, " +
                               "@calificacionTres,@calificacionFinal,@activo ,@idEstudiante) " +
                               "SELECT CAST(SCOPE_IDENTITY() as int) AS idMateriasCursadas";

                var parametros = materias.ObtenerParametros();

                //5- Ejcutar la consulta (query)
                idMaterias = db.QuerySingle<int>(query, parametros);
                //6- Ejecutar la consulta para obtner el empleado
                //7- Crea el objeto empleado de Models

                // Alternativa 
                materias.IdMateriasCursadas = idMaterias;
            }
            //8- Retornar el empleado de Models
            return materias;
        }

        public Models.MateriasCursadas Actualizar(Models.MateriasCursadas materias)
        {
            //1- Inicio
            //2- Recibir el empleado actualizar
            //3- Obtner cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {

                //5- Crear el query para actualizar
                string query = "UPDATE MateriasCursadas SET claveMateria=@claveMateria,materia=@materia ,calificacionUno=@calificacionUno ,calificacionDos=@calificacionDos, " +
                               "calificacionTres=@calificacionTres,calificacionFinal=@calificacionFinal,activo=@activo ,idEstudiante=@idEstudiante " +
                               "WHERE idMateriasCursadas=@idMateriasCursadas";

                var parametros = materias.ObtenerParametros();

                //6- Ejecutar el query de actualizar
                int numRegistroAfectados = db.Execute(query, parametros);


            }

            return materias;
        }
    }
}
