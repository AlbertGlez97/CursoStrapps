using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.WebAPI.Models
{
    public class Estudiante: DatosEscolares
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public char Sexo { get; set; }
        public string CURP { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Activo { get; set; }
        public Direccion direccion { get; set; }

    
        public Estudiante()
        {

        }

        public Estudiante(dynamic elemento)
        {
                //Datos del Estudiante
                this.IdEstudiante = elemento.idEstudiante;
                this.Nombre = elemento.nombre;
                this.ApellidoPaterno = elemento.apellidoPaterno;
                this.ApellidoMaterno = elemento.apellidoMaterno;
                this.Sexo = char.Parse(elemento.sexo.ToString());
                this.CURP = elemento.curp;
                this.FechaNacimiento = elemento.fechaNacimiento;
                this.Nacionalidad = elemento.nacionalidad;
                this.Telefono = elemento.telefono;
                this.CorreoElectronico = elemento.correoElectronico;
                this.Activo = elemento.activo;

                //Datos de direccion
                this.direccion = new Models.Direccion();
                this.direccion.idDireccion = elemento.idDireccion;
                this.direccion.Calle = elemento.calle;
                this.direccion.NumeroExterior = elemento.numeroExterior;
                this.direccion.NumeroInterior = elemento.numeroInterior;
                this.direccion.Colonia = elemento.colonia;
                this.direccion.Municipio = elemento.municipio;
                this.direccion.Estado = elemento.estado;
                this.direccion.CodigoPostal = elemento.codigoPostal;

                //Datos Escolares
                this.IdDatosEscolares = elemento.idDatosEscolares;
                this.NumeroMatricula= elemento.numeroMatricula;
                this.Carrera= elemento.carrera;
                this.FechaIngreso= elemento.fechaIngreso ;
                this.Semestre= elemento.semestre ;
        }

        public object ObtenerParametros()
        {
            object parametros = new
            {
                //Datos del Estudiante
                idEstudiante = this.IdEstudiante,
                nombre = this.Nombre,
                apellidoPaterno = this.ApellidoPaterno,
                apellidoMaterno = this.ApellidoMaterno,
                sexo =this.Sexo ,
                curp = this.CURP,
                fechaNacimiento = this.FechaNacimiento,
                nacionalidad = this.Nacionalidad,
                telefono = this.Telefono,
                correoElectronico = this.CorreoElectronico,
                activo = this.Activo,

                //Datos de direccion
                idDireccion = this.direccion.idDireccion,
                calle = this.direccion.Calle,
                numeroExterior = this.direccion.NumeroExterior,
                numeroInterior = this.direccion.NumeroInterior,
                colonia = this.direccion.Colonia,
                municipio = this.direccion.Municipio,
                estado = this.direccion.Estado,
                codigoPostal = this.direccion.CodigoPostal,

                //Datos Escolares
                idDatosEscolares = this.IdDatosEscolares,
                numeroMatricula = this.NumeroMatricula,
                carrera = this.Carrera,
                fechaIngreso = this.FechaIngreso,
                semestre = this.Semestre,
            };

            return parametros;
        }


    }

}
