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
    public class MateriasCursadasController : ControllerBase
    {

        private readonly IConfiguration configuration;
        private readonly MateriasCursadasDA materiasCursadasDA;

        private readonly ILogger<MateriasCursadasController> _logger;

        public MateriasCursadasController(ILogger<MateriasCursadasController> logger,IConfiguration configuration)
        {
            _logger = logger;
            configuration = configuration;
            this.materiasCursadasDA = new MateriasCursadasDA(configuration);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.MateriasCursadas>>> Obtener()
        {
            // 1-Inicio
            // 2-Buscar empleado activos en la base de datos
            List<Models.MateriasCursadas> lista = materiasCursadasDA.ObtenerMateriasCursadasDA();
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
        [HttpGet("{idMateriasCursadas}")]
        public async Task<ActionResult<Models.MateriasCursadas>> ObtenerPorIdMateria(int idMateriasCursadas)
        {
            // 1.- Inicio 
            // 2.- Declaración de variable para empleado a modificar
            Models.MateriasCursadas materiaEncontradaDelEstudiante = materiasCursadasDA.ObtenerPorIdMateria(idMateriasCursadas);

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
        public async Task<ActionResult<IEnumerable<Models.MateriasCursadas>>> ObtenerPorIdAlumnos(int idEstudiante)
        {
            // 1.- Inicio 
            // 2.- Declaración de variable para empleado a modificar
            List<Models.MateriasCursadas> materiaEncontradaDelEstudiante = materiasCursadasDA.ObtenerPorIdAlumnos(idEstudiante);

            if (materiaEncontradaDelEstudiante == null)
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
        public async Task<ActionResult<Models.MateriasCursadas>> Crear(Models.MateriasCursadas estudiante)
        {

            //1- Inicio
            //2- Recibir parametros de entrada
            //3- Activar el empleado
            estudiante.Activo = true;
            //4- Insertar el empleado
            estudiante = materiasCursadasDA.Crear(estudiante);
            //5- Obtener el empleado inserta en base de datos
            //6- Fin 


            // Retornamos al empleado agregado
            return estudiante;
        }

        [HttpPut]
        public async Task<ActionResult<Models.MateriasCursadas>> Actualizar(Models.MateriasCursadas materia)
        {
            //1- Inicio
            //2- Recibir los parametros
            //3- Buscar el empleado por id en la base de de datos
            Models.MateriasCursadas materiaActualizar = materiasCursadasDA.ObtenerPorIdMateria(materia.IdMateriasCursadas);

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
                materiaActualizar.CalificacionUno = materia.CalificacionUno;
                materiaActualizar.CalificacionDos = materia.CalificacionDos;
                materiaActualizar.CalificacionTres = materia.CalificacionTres;
                materiaActualizar.CalificacionFinal = materia.CalificacionFinal;
                materiaActualizar.Activo = materia.Activo;
                materiaActualizar.IdEstudiante = materia.IdEstudiante;

                materiasCursadasDA.Actualizar(materiaActualizar);
            }

            //6- Retornar 
            return materiaActualizar;

            // 7.- Fin

        }

        [HttpDelete("{idMateriasCursadas}")]
        public async Task<ActionResult<Models.MateriasCursadas>> Eliminar(int idMateriasCursadas)
        {

            // 1- Inicio
            // 2- Recibir parametro idEmpleado
            // 3- Buscar el empleado en la base de datos por el idEmpleado
            Models.MateriasCursadas materiaActualizar = materiasCursadasDA.ObtenerPorIdMateria(idMateriasCursadas);
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
                materiasCursadasDA.Actualizar(materiaActualizar);
            }

            // 6-Retornar el empleado eliminado

            return materiaActualizar;

        }




    }
}
