using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models = Empleado.WebAPI.Models;
using Microsoft.Extensions.Configuration;
using Empleado.WebAPI.DataAccess;

namespace Empleado.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadosController : ControllerBase
    {
        public static List<Models.Empleado> listEmpleado = new List<Models.Empleado>();
        private readonly ILogger<EmpleadosController> _logger;
        private readonly IConfiguration configuration;
        private readonly EmpleadoDA empleadoDA;

        public EmpleadosController(ILogger<EmpleadosController> logger,IConfiguration configuration)
        {
            _logger = logger;
            configuration = configuration;
            this.empleadoDA = new EmpleadoDA(configuration);
        }

        

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Empleado>>> Obtener()
        {
            // 1-Inicio
            // 2-Buscar empleado activos en la base de datos
             List <Models.Empleado> lista = empleadoDA.ObtenerEmpleados();
            // 3-Si encontro ningun registro regresar un not foun
            if(lista.Count == 0)
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
  
        [HttpPost]
        public async Task<ActionResult<Models.Empleado>> Crear(Models.Empleado empleado)
        {
           
            //1- Inicio
            //2- Recibir parametros de entrada
            //3- Activar el empleado
            empleado.Activo = true;
            //4- Insertar el empleado
            empleado = empleadoDA.Crear(empleado);
            //5- Obtener el empleado inserta en base de datos
            //6- Fin 


            // Retornamos al empleado agregado
            return empleado; 
        } 
        // Fin
        [HttpPut]
        public async Task<ActionResult<Models.Empleado>> Actualizar(Models.Empleado empleado)
        {
            //1- Inicio
            //2- Recibir los parametros
            //3- Buscar el empleado por id en la base de de datos
            Models.Empleado empleadoActualizar = empleadoDA.Obtener(empleado.idEmpleado);

            //4- Si el empleado no existe, retorna un not found
            if(empleadoActualizar == null)
            {
               //Regresar un error de empleado no encontrado
               return NotFound();
            }
            else
            {
            //5- Si el empleado exite, cambia sus valores y mandar actualizar a base de datos
                    
                    //Datos de Empleado
                    empleadoActualizar.RFC = empleado.RFC;
                    empleadoActualizar.Puesto = empleado.Puesto;
                    empleadoActualizar.FechadeIngreso = empleado.FechadeIngreso;
                    empleadoActualizar.SalarioDiario = empleado.SalarioDiario;
                    empleadoActualizar.NSS = empleado.NSS;
                    empleadoActualizar.Horario = empleado.Horario;
                    empleadoActualizar.TotalFaltas = empleado.TotalFaltas;
                    empleadoActualizar.Activo = empleado.Activo;
                    
                    //Datos de Persona
                    empleadoActualizar.idPersona = empleado.idPersona;
                    empleadoActualizar.Nombre = empleado.Nombre;
                    empleadoActualizar.ApellidoPaterno = empleado.ApellidoPaterno;
                    empleadoActualizar.ApellidoMaterno = empleado.ApellidoMaterno;
                    empleadoActualizar.Sexo = empleado.Sexo;
                    empleadoActualizar.CURP = empleado.CURP;
                    empleadoActualizar.Telefono = empleado.Telefono;
                    empleadoActualizar.CorreoElectronico = empleado.CorreoElectronico;
                    empleadoActualizar.FechaNacimiento = empleado.FechaNacimiento;
                    empleadoActualizar.Nacionalidad = empleado.Nacionalidad;

                    //Datos de direccion
                    empleadoActualizar.direccion.Calle = empleado.direccion.Calle;
                    empleadoActualizar.direccion.NumeroExterior = empleado.direccion.NumeroExterior;
                    empleadoActualizar.direccion.NumeroInterior = empleado.direccion.NumeroInterior;
                    empleadoActualizar.direccion.Colonia = empleado.direccion.Colonia;
                    empleadoActualizar.direccion.Municipio = empleado.direccion.Municipio;
                    empleadoActualizar.direccion.Estado = empleado.direccion.Estado;
                    empleadoActualizar.direccion.CodigoPostal = empleado.direccion.CodigoPostal;

                    empleadoDA.Actualizar(empleadoActualizar);

            }
            
            //6- Retornar 
            return empleadoActualizar;

            // 7.- Fin

        }
     
        [HttpGet ("{idEmpleado}")]
        public async Task<ActionResult<Models.Empleado>> ObtenerPorIdEmpleado(int idEmpleado)
        {
            // 1.- Inicio 
            // 2.- Declaración de variable para empleado a modificar
            Models.Empleado empleadoEncontrado = empleadoDA.Obtener(idEmpleado);
            
            if(empleadoEncontrado == null)
            {
                // Regresar un error de empleado no encontrado
                return NotFound();
            }
            else
            {
            
                return empleadoEncontrado;
            }
        }

        // 8.- Fin
        [HttpDelete ("{idEmpleado}")]

        public async Task<ActionResult<Models.Empleado>> Eliminar(int idEmpleado)
        {

            // 1- Inicio
            // 2- Recibir parametro idEmpleado
            // 3- Buscar el empleado en la base de datos por el idEmpleado
            Models.Empleado empleadoActualizar = empleadoDA.Obtener(idEmpleado);
            // 4- Si no se encontro, retornamos un not found
            if(empleadoActualizar == null)
            {
                // Regresar un error de empleado no encontrado
                return NotFound();
            }
            // 5- Si lo encontramos
            else
            {
                //BAJA LOGICA, porque se modifica su campo activo
                // 5.1 Desactivar el empleado cambiando el estatus
                empleadoActualizar.Activo = false;
                // 5.2 Guardar el estatus del empleado
                empleadoDA.Actualizar(empleadoActualizar);
            }
                
            // 6-Retornar el empleado eliminado

            return empleadoActualizar;

        }
        // 9.- Fin
    }
}