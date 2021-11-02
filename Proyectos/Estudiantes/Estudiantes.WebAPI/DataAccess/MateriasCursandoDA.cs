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
    public class MateriasCursandoDA
    {
        private readonly IConfiguration configuration;

        public MateriasCursandoDA(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public List<Models.MateriasCursando> ObtenerMateriasCursando()
        {
            List<Models.MateriasCursando> listaMateriasCursando = new List<Models.MateriasCursando>();
            //Esta cadena de conexion , va a acceder a nuestro appsettings.Development.json
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var query = "SELECT idMateriasCursando,claveMateria,materia ,horario ,calificacionUno ,calificacionDos, " +
                            "calificacionTres,activo ,idEstudiante " +
                            "FROM MateriasCursando WHERE MateriasCursando.activo=1";

                var resultado = db.Query(query).ToList();

                //Iteramos el resultado
                foreach (var elemento in resultado)
                {
                    Models.MateriasCursando materias = new Models.MateriasCursando(elemento);
                    listaMateriasCursando.Add(materias);
                }
            }
            return listaMateriasCursando;
        }

        public Models.MateriasCursando ObtenerPorIdMateria(int idMateriasCursando)
        {
            //1- Inicio
            Models.MateriasCursando materiasCursando = null;
            //2- Recibir el id Empleado
            //3- Obtener la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //5- Craer la consulta (query)
                string query = "SELECT idMateriasCursando,claveMateria,materia ,horario ,calificacionUno ,calificacionDos, " +
                               "calificacionTres,activo ,idEstudiante " +
                               "FROM MateriasCursando WHERE activo=1 AND idMateriasCursando = @idMateriasCursando";

                //6- Ejecutar la consulta
                var resultado = db.QueryFirstOrDefault(query, new { idMateriasCursando = idMateriasCursando });

                //7-Validar y Crear un objeto modelo con la informacion de la base de datos (Dapper)
                if (resultado != null)
                {
                    materiasCursando = new Models.MateriasCursando(resultado);
                }
                else
                {
                    materiasCursando = null;
                }
            }
            return materiasCursando;
        }

        public List<Models.MateriasCursando> ObtenerPorIdAlumnos(int idEstudiante)
        {
            //1- Inicio
            List<Models.MateriasCursando> listaMateriasCursando = new List<Models.MateriasCursando>();
            //Models.MateriasCursando materiasCursando = null;
            //2- Recibir el id Empleado
            //3- Obtener la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //5- Craer la consulta (query)
                string query = "SELECT idMateriasCursando,claveMateria,materia ,horario ,calificacionUno ,calificacionDos, " +
                               "calificacionTres,activo ,idEstudiante  " +
                               "FROM MateriasCursando WHERE activo=1 AND idEstudiante =" + idEstudiante;

                //6- Ejecutar la consulta
                var resultado = db.Query(query).ToList();
 
                foreach (var elemento in resultado)
                    {
                        Models.MateriasCursando materias = new Models.MateriasCursando(elemento);
                        listaMateriasCursando.Add(materias);
                    }
                   
               
            }
            return listaMateriasCursando;
        }

        public Models.MateriasCursando Crear(Models.MateriasCursando materias)
        {
            //1- Inicio
            int idMaterias;
            //2- Obtner la cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //3- Crear Conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                //4- Crear el query para insertar
                string query = "INSERT INTO MateriasCursando(claveMateria,materia ,horario ,calificacionUno ,calificacionDos, " +
                               "calificacionTres,activo ,idEstudiante) " +
                               "VALUES (@claveMateria,@materia ,@horario ,@calificacionUno ,@calificacionDos, " +
                               "@calificacionTres,@activo ,@idEstudiante) " +
                               "SELECT CAST(SCOPE_IDENTITY() as int) AS idMateriasCursando";

                var parametros = materias.ObtenerParametros();

                //5- Ejcutar la consulta (query)
                idMaterias = db.QuerySingle<int>(query, parametros);
                //6- Ejecutar la consulta para obtner el empleado
                //7- Crea el objeto empleado de Models

                // Alternativa 
                materias.IdMateriasCursando = idMaterias;
            }
            //8- Retornar el empleado de Models
            return materias;
        }

        public Models.MateriasCursando Actualizar(Models.MateriasCursando materias)
        {
            //1- Inicio
            //2- Recibir el empleado actualizar
            //3- Obtner cadena de conexion
            string cadenaConexion = configuration.GetConnectionString("EstudianteConnection");

            //4- Crear el objeto conexion
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {

                //5- Crear el query para actualizar
                string query = "UPDATE MateriasCursando SET claveMateria=@claveMateria,materia=@materia ,horario=@horario ,calificacionUno=@calificacionUno ,calificacionDos=@calificacionDos, " +
                               "calificacionTres=@calificacionTres,activo=@activo ,idEstudiante=@idEstudiante " +
                               "WHERE idMateriasCursando=@idMateriasCursando";

                var parametros = materias.ObtenerParametros();

                //6- Ejecutar el query de actualizar
                int numRegistroAfectados = db.Execute(query, parametros);


            }

            return materias;
        }
    }
}
