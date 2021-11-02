using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models = Estudiantes.WebAPI.Models;
using Estudiantes.WebAPI.DataAccess;

namespace Estudiantes.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MateriasCursandoController : ControllerBase
    {

        public static List<Models.MateriasCursando> listEmpleado = new List<Models.MateriasCursando>();
        private readonly IConfiguration configuration;
        private readonly MateriasCursandoDA materiasCursandoDA;

        private readonly ILogger<MateriasCursandoController> _logger;

        public MateriasCursandoController(ILogger<MateriasCursandoController> logger,IConfiguration configuration)
        {
            _logger = logger;
            configuration = configuration;
            this.materiasCursandoDA = new MateriasCursandoDA(configuration);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.MateriasCursando>>> Obtener()
        {
            // 1-Inicio
            // 2-Buscar empleado activos en la base de datos
            List<Models.MateriasCursando> lista = materiasCursandoDA.ObtenerMateriasCursando();
            // 3-Si encontro ningun registro regresar un not foun
            if (lista.Count == 0)
            {
                return NotFound();
            }
            // 4-Si se encontro algun registro retornar los registros encontrados
            else
            {
                return lista;
            }
            // 5-Fin
        }
        /*
        [HttpGet("{idMateriasCursando}")]
        public async Task<ActionResult<Models.MateriasCursando>> ObtenerPorIdMateria(int idMateriasCursando)
        {
            // 1.- Inicio 
            // 2.- Declaración de variable para empleado a modificar
            Models.MateriasCursando materiaEncontradaDelEstudiante = materiasCursandoDA.ObtenerPorIdMateria(idMateriasCursando);

            if (materiaEncontradaDelEstudiante == null)
            {
                // Regresar un error de empleado no encontrado
                return NotFound();
            }
            else
            {

                return materiaEncontradaDelEstudiante;
            }
        }*/

        [HttpGet("{idEstudiante}")]
        public async Task<ActionResult<IEnumerable<Models.MateriasCursando>>> ObtenerPorIdAlumnos(int idEstudiante)
        {
            // 1.- Inicio 
            // 2.- Declaración de variable para empleado a modificar
            //Models.MateriasCursando materiaEncontradaDelEstudiante = materiasCursandoDA.ObtenerPorIdAlumnos(idEstudiante);
            List<Models.MateriasCursando> materiaEncontradaDelEstudiante = materiasCursandoDA.ObtenerPorIdAlumnos(idEstudiante);
            if (materiaEncontradaDelEstudiante.Count == 0)
            {
                // Regresar un error de empleado no encontrado
                return NotFound();
            }
            else
            {

                return materiaEncontradaDelEstudiante;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Models.MateriasCursando>> Crear(Models.MateriasCursando estudiante)
        {

            //1- Inicio
            //2- Recibir parametros de entrada
            //3- Activar el empleado
            estudiante.Activo = true;
            //4- Insertar el empleado
            estudiante = materiasCursandoDA.Crear(estudiante);
            //5- Obtener el empleado inserta en base de datos
            //6- Fin 


            // Retornamos al empleado agregado
            return estudiante;
        }

        [HttpPut]
        public async Task<ActionResult<Models.MateriasCursando>> Actualizar(Models.MateriasCursando materia)
        {
            //1- Inicio
            //2- Recibir los parametros
            //3- Buscar el empleado por id en la base de de datos
            Models.MateriasCursando materiaActualizar = materiasCursandoDA.ObtenerPorIdMateria(materia.IdMateriasCursando);

            //4- Si el empleado no existe, retorna un not found
            if (materiaActualizar == null)
            {
                //Regresar un error de empleado no encontrado
                return NotFound();
            }
            else
            {
                //5- Si el empleado exite, cambia sus valores y mandar actualizar a base de datos

               //Materias Cursando
               materiaActualizar.ClaveMateria = materia.ClaveMateria;
               materiaActualizar.Materia = materia.Materia;
               materiaActualizar.Horario = materia.Horario;
               materiaActualizar.CalificacionUno = materia.CalificacionUno;
               materiaActualizar.CalificacionDos = materia.CalificacionDos;
               materiaActualizar.CalificacionTres = materia.CalificacionTres;
               materiaActualizar.Activo = materia.Activo;
               materiaActualizar.IdEstudiante = materia.IdEstudiante;

                materiasCursandoDA.Actualizar(materiaActualizar);
            }

            //6- Retornar 
            return materiaActualizar;

            // 7.- Fin

        }

        [HttpDelete("{idMateriasCursando}")]
        public async Task<ActionResult<Models.MateriasCursando>> Eliminar(int idMateriasCursando)
        {

            // 1- Inicio
            // 2- Recibir parametro idEmpleado
            // 3- Buscar el empleado en la base de datos por el idEmpleado
            Models.MateriasCursando materiaActualizar = materiasCursandoDA.ObtenerPorIdMateria(idMateriasCursando);
            // 4- Si no se encontro, retornamos un not found
            if (materiaActualizar == null)
            {
                // Regresar un error de empleado no encontrado
                return NotFound();
            }
            // 5- Si lo encontramos
            else
            {
                //BAJA LOGICA, porque se modifica su campo activo
                // 5.1 Desactivar el empleado cambiando el estatus
                materiaActualizar.Activo = false;
                // 5.2 Guardar el estatus del empleado
                materiasCursandoDA.Actualizar(materiaActualizar);
            }

            // 6-Retornar el empleado eliminado

            return materiaActualizar;

        }



    }
}
