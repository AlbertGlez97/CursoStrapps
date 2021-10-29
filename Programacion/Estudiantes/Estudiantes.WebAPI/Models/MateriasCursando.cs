using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.WebAPI.Models
{
    public class MateriasCursando
    {
        public int IdMateriasCursando { get; set; }
        public long ClaveMateria { get; set; }
        public String Materia { get; set; }
        public String Horario { get; set; }
        public double CalificacionUno { get; set; }
        public double CalificacionDos { get; set; }
        public double CalificacionTres { get; set; }
        public bool Activo { get; set; }
        public int IdEstudiante { get; set; }

        public MateriasCursando()
        {
        }
        public MateriasCursando(dynamic elemento)
        {
            //Materias Cursando
            this.IdMateriasCursando = elemento.idMateriasCursando;
            this.ClaveMateria = elemento.claveMateria;
            this.Materia = elemento.materia;
            this.Horario = elemento.horario;
            this.CalificacionUno = elemento.calificacionUno;
            this.CalificacionDos = elemento.calificacionDos;
            this.CalificacionTres = elemento.calificacionTres;
            this.Activo = elemento.activo;
            this.IdEstudiante = elemento.idEstudiante;
        }

        public object ObtenerParametros()
        {
            object parametros = new
            {
                idMateriasCursando= this.IdMateriasCursando,
                claveMateria = this.ClaveMateria,
                materia = this.Materia,
                horario = this.Horario,
                calificacionUno = this.CalificacionUno,
                calificacionDos = this.CalificacionDos,
                calificacionTres = this.CalificacionTres,
                activo = this.Activo,
                idEstudiante = this.IdEstudiante

            };

            return parametros;
        }
    }
}
