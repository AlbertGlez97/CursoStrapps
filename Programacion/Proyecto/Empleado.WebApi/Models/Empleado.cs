using System;

namespace Empleado.WebApi.Models{
    public class Empleado:Persona
    {
        public int idEmpleado { get; set; }
        public string rfc { get; set; }
        public string puesto { get; set; }
        public string fechaIngreso { get; set; }
        public string salarioDiario { get; set; }
        public string nss { get; set; }
        public string horario { get; set; }
        public int totalFaltas { get; set; }
        public bool activo { get; set; }

    }
}