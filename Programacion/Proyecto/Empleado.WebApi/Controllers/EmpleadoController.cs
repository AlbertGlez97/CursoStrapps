using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models = Empleado.WebApi.Models;

namespace Empleado.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : ControllerBase
    {
        public static List<Models.Empleado> listEmpleados = new List<Models.Empleado>()
        {
            new Models.Empleado(){
                idEmpleado = 1,
                nombre = "Alberto",
                apellidoPaterno = "PEREZ",
                apellidoMaterno= "PEREZ",
                sexo = 'M',
                activo = true
            },
            new Models.Empleado(){
                idEmpleado = 2,
                nombre = "JUAN",
                apellidoPaterno = "PEREZ",
                apellidoMaterno= "PEREZ",
                sexo = 'M',
                activo = true
            },
            new Models.Empleado(){
                idEmpleado = 3,
                nombre = "FERNANDO",
                apellidoPaterno = "PEREZ",
                apellidoMaterno= "PEREZ",
                sexo = 'M',
                activo = true
            }
        };
        private readonly ILogger<EmpleadoController> _logger;

        public EmpleadoController(ILogger<EmpleadoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Models.Empleado> Obtener()
        {

            List<Models.Empleado> listaEmpleadosActivos = new List<Models.Empleado>();

            List<Models.Empleado> lista = listEmpleados;

            foreach (var empleado in lista)
            {
                if(empleado.activo == true){

                    listaEmpleadosActivos.Add(empleado);

                }
            }

            return listaEmpleadosActivos;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Empleado>> ObtenerEmpleado(int id)
        {
            Models.Empleado empleadoEncontrado = null;

            List<Models.Empleado> listaEmp = listEmpleados;

            foreach (Models.Empleado iEmpleado in listaEmp)
            {
                if (iEmpleado.idEmpleado == id)
                {
                    empleadoEncontrado = iEmpleado; 
                    break;
                }
            }
            if (empleadoEncontrado ==  null)
            {
                return NotFound();
            }else{
                return empleadoEncontrado;
            }

        }


        [HttpPost]
        public Models.Empleado Crear(Models.Empleado empleado) {
            
            Models.Empleado ultiEmpleado = listEmpleados.Last();
            
            // aumentamos en uno el id del nuevo empleado
            // dependiendo en que id se quedo el ultimo registro
            empleado.idEmpleado = ultiEmpleado.idEmpleado + 1;
            
            listEmpleados.Add(empleado);
            
            return empleado;
        }

        [HttpPut]
        public async Task<ActionResult<Models.Empleado>> Actualizar(Models.Empleado empleado){

            Models.Empleado empleadoModificar = null;

            // foreach (Empleado iEmpleado in listEmpleados)
            // {
            //     if(iEmpleado.idEmpleado == empleado.idEmpleado){
            //         iEmpleado.nombre = empleado.nombre;
            //         iEmpleado.apellidoPaterno = empleado.apellidoPaterno;
            //         iEmpleado.apellidoMaterno = empleado.apellidoMaterno;
            //         empleadoActualziado = iEmpleado;
            //     }
            // }

            List<Models.Empleado> listaEmp = listEmpleados;

            foreach (Models.Empleado iEmpleado in listaEmp)
            {
                if (iEmpleado.idEmpleado == empleado.idEmpleado)
                {
                    empleadoModificar = iEmpleado;
                    break;
                }
            }

            if (empleadoModificar == null)
            {
                return NotFound();
            }else
            {
                empleadoModificar.nombre = empleado.nombre;
                empleadoModificar.apellidoPaterno = empleado.apellidoPaterno;
                empleadoModificar.apellidoMaterno = empleado.apellidoMaterno;

            }

            return empleadoModificar;

        }

        // eliminar
        [HttpDelete("{idEmpleado}")]
        public async Task<ActionResult<Models.Empleado>> eliminar( int idEmpleado ){

            Models.Empleado empleadoEliminar = null;

            List<Models.Empleado> list = listEmpleados;

            // al usar var c# evalua de manera dinamica
            // que tipo es la variable
            foreach (var empleado in list)
            {
                if (empleado.idEmpleado == idEmpleado)
                {
                    empleadoEliminar = empleado;
                    break;
                }
            }

            if (empleadoEliminar == null)
            {
                return NotFound();
            }

            if(empleadoEliminar != null){
                empleadoEliminar.activo = false;
            }

            return empleadoEliminar;
        }

    }
}
