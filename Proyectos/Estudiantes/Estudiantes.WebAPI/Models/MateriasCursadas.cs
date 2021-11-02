using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.WebAPI.Models
{
    public class MateriasCursadas
    {
        public int IdMateriasCursadas { get; set; }
        public long ClaveMateria { get; set; }
        public String Materia { get; set; }
        public double CalificacionUno { get; set; }
        public double CalificacionDos { get; set; }
        public double CalificacionTres { get; set; }
        public double CalificacionFinal { get; set; }
        public bool Activo { get; set; }
        public int IdEstudiante { get; set; }

        public MateriasCursadas()
        {
        }

        public MateriasCursadas(dynamic elemento)
        {
            //Materias Cursando
            this.IdMateriasCursadas = elemento.idMateriasCursadas;
            this.ClaveMateria = elemento.claveMateria;
            this.Materia = elemento.materia;
            this.CalificacionUno = elemento.calificacionUno;
            this.CalificacionDos = elemento.calificacionDos;
            this.CalificacionTres = elemento.calificacionTres;
            this.CalificacionFinal = elemento.calificacionFinal;
            this.Activo = elemento.activo;
            this.IdEstudiante = elemento.idEstudiante;
        }

        public object ObtenerParametros()
        {
            object parametros = new
            {
                idMateriasCursadas = this.IdMateriasCursadas,
                claveMateria = this.ClaveMateria,
                materia = this.Materia,
                calificacionUno = this.CalificacionUno,
                calificacionDos = this.CalificacionDos,
                calificacionTres = this.CalificacionTres,
                calificacionFinal = this.CalificacionFinal,
                activo = this.Activo,
                idEstudiante = this.IdEstudiante

            };

            return parametros;
        }


    }
}
