using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models = Estudiantes.WebAPI.Models;
using Estudiantes.WebAPI.DataAccess;
using Microsoft.Extensions.Configuration;

namespace Estudiantes.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudiantesController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly EstudianteDA estudianteDA;

        private readonly ILogger<EstudiantesController> _logger;

        public EstudiantesController(ILogger<EstudiantesController> logger, IConfiguration configuration)
        {
            _logger = logger;
            configuration = configuration;
            this.estudianteDA = new EstudianteDA(configuration);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Estudiante>>> Obtener()
        {
            // 1-Inicio
            // 2-Buscar empleado activos en la base de datos
            List<Models.Estudiante> lista = estudianteDA.ObtenerEstudiantes();
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

        [HttpGet("{idEstudiante}")]
        public async Task<ActionResult<Models.Estudiante>> ObtenerPorIdEstudiante(int idEstudiante)
        {
            // 1.- Inicio 
            // 2.- Declaración de variable para empleado a modificar
            Models.Estudiante estudianteEncontrado = estudianteDA.ObtenerPorIdEstudiante(idEstudiante);

            if (estudianteEncontrado == null)
            {
                // Regresar un error de empleado no encontrado
                return NotFound();
            }
            else
            {

                return estudianteEncontrado;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Models.Estudiante>> Crear(Models.Estudiante estudiante)
        {

            //1- Inicio
            //2- Recibir parametros de entrada
            //3- Activar el empleado
            estudiante.Activo = true;
            //4- Insertar el empleado
            estudiante = estudianteDA.Crear(estudiante);
            //5- Obtener el empleado inserta en base de datos
            //6- Fin 


            // Retornamos al empleado agregado
            return estudiante;
        }

        [HttpPut]
        public async Task<ActionResult<Models.Estudiante>> Actualizar(Models.Estudiante estudiante)
        {
            //1- Inicio
            //2- Recibir los parametros
            //3- Buscar el empleado por id en la base de de datos
            Models.Estudiante estudianteActualizar = estudianteDA.ObtenerPorIdEstudiante(estudiante.IdEstudiante);

            //4- Si el empleado no existe, retorna un not found
            if (estudianteActualizar == null)
            {
                //Regresar un error de empleado no encontrado
                return NotFound();
            }
            else
            {
                //5- Si el empleado exite, cambia sus valores y mandar actualizar a base de datos

                //Datos del Estudiante
                estudianteActualizar.Nombre = estudiante.Nombre;
                estudianteActualizar.ApellidoPaterno = estudiante.ApellidoPaterno;
                estudianteActualizar.ApellidoMaterno = estudiante.ApellidoMaterno;
                estudianteActualizar.Sexo = estudiante.Sexo;
                estudianteActualizar.CURP = estudiante.CURP;
                estudianteActualizar.FechaNacimiento = estudiante.FechaNacimiento;
                estudianteActualizar.Nacionalidad = estudiante.Nacionalidad;
                estudianteActualizar.Telefono = estudiante.Telefono;
                estudianteActualizar.CorreoElectronico = estudiante.CorreoElectronico;
                estudianteActualizar.Activo = estudiante.Activo;

                //Datos de direccion
                estudianteActualizar.direccion.idDireccion = estudiante.direccion.idDireccion;
                estudianteActualizar.direccion.Calle = estudiante.direccion.Calle;
                estudianteActualizar.direccion.NumeroExterior = estudiante.direccion.NumeroExterior;
                estudianteActualizar.direccion.NumeroInterior = estudiante.direccion.NumeroInterior;
                estudianteActualizar.direccion.Colonia = estudiante.direccion.Colonia;
                estudianteActualizar.direccion.Municipio = estudiante.direccion.Municipio;
                estudianteActualizar.direccion.Estado = estudiante.direccion.Estado;
                estudianteActualizar.direccion.CodigoPostal = estudiante.direccion.CodigoPostal;

                //Datos Escolares
                estudianteActualizar.IdDatosEscolares = estudiante.IdDatosEscolares;
                estudianteActualizar.NumeroMatricula = estudiante.NumeroMatricula;
                estudianteActualizar.Carrera = estudiante.Carrera;
                estudianteActualizar.FechaIngreso = estudiante.FechaIngreso;
                estudianteActualizar.Semestre = estudiante.Semestre;
                estudianteDA.Actualizar(estudianteActualizar);

            }

            //6- Retornar 
            return estudianteActualizar;

            // 7.- Fin

        }

        [HttpDelete("{idEstudiante}")]
        public async Task<ActionResult<Models.Estudiante>> Eliminar(int idEstudiante)
        {

            // 1- Inicio
            // 2- Recibir parametro idEmpleado
            // 3- Buscar el empleado en la base de datos por el idEmpleado
            Models.Estudiante estudianteActualizar = estudianteDA.ObtenerPorIdEstudiante(idEstudiante);
            // 4- Si no se encontro, retornamos un not found
            if (estudianteActualizar == null)
            {
                // Regresar un error de empleado no encontrado
                return NotFound();
            }
            // 5- Si lo encontramos
            else
            {
                //BAJA LOGICA, porque se modifica su campo activo
                // 5.1 Desactivar el empleado cambiando el estatus
                estudianteActualizar.Activo = false;
                // 5.2 Guardar el estatus del empleado
                estudianteDA.Actualizar(estudianteActualizar);
            }

            // 6-Retornar el empleado eliminado

            return estudianteActualizar;

        }



    }
}
