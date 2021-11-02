using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.WebAPI.Models
{
    public class DatosEscolares
    {
        public int IdDatosEscolares { get; set; }
        public long NumeroMatricula { get; set; }
        public String Carrera { get; set; }
        public DateTime FechaIngreso { get; set; }
        public String Semestre { get; set; }
    }
}
