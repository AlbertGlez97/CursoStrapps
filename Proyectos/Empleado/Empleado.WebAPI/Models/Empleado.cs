using System;
using System.Collections.Generic;

namespace Empleado.WebAPI.Models
{
    public class Empleado:Persona
    {
        public int idEmpleado { get; set; }
        public string RFC { get; set; }
        public string Puesto { get; set; }
        public DateTime FechadeIngreso { get; set; }
        public decimal SalarioDiario { get; set; }
        public long NSS { get; set; }
        public string Horario { get; set; }
        public int TotalFaltas { get; set; }
        public bool Activo { get; set; }

        public Empleado()
        {

        }
     
        public Empleado(dynamic elemento)
        {

                //Datos de Empleado
                this.idEmpleado = elemento.idEmpleado;
                this.RFC= elemento.RFC;
                this.Puesto = elemento.puesto;
                this.FechadeIngreso= elemento.fechaIngreso;
                this.SalarioDiario= elemento.salarioDiario;
                this.NSS = elemento.NSS;
                this.Horario= elemento.horario;
                this.TotalFaltas = elemento.totalFaltas;
                this.Activo= elemento.activo;

                //Datos de Persona
                this.idPersona = elemento.idPersona;
                this.Nombre= elemento.nombre;
                this.ApellidoPaterno= elemento.apellidoPaterno;
                this.ApellidoMaterno= elemento.apellidoMaterno;
                this.Sexo= char.Parse(elemento.sexo.ToString());
                this.CURP = elemento.curp;
                this.Telefono= elemento.telefono;
                this.CorreoElectronico= elemento.correoElectronico;
                this.FechaNacimiento= elemento.fechaNacimiento;
                this.Nacionalidad= elemento.nacionalidad;

                //Datos de direccion
                this.direccion = new Models.Direccion();
                this.direccion.idDireccion =elemento.idDireccion;
                this.direccion.Calle=elemento.calle;
                this.direccion.NumeroExterior =elemento.numeroExterior;
                this.direccion.NumeroInterior =elemento.numeroInterior;
                this.direccion.Colonia =elemento.colonia;
                this.direccion.Municipio =elemento.municipio;
                this.direccion.Estado =elemento.estado;
                this.direccion.CodigoPostal =elemento.codigoPostal;  

        }

        public object ObtenerParametros()
        {
            object parametros = new 
            {
                //Datos de Persona
                    idPersona = this.idPersona,
                    nombre = this.Nombre,
                    apellidoPaterno = this.ApellidoPaterno,
                    apellidoMaterno = this.ApellidoMaterno,
                    sexo = this.Sexo,
                    curp = this.CURP,
                    telefono = this.Telefono,
                    correoElectronico = this.CorreoElectronico,
                    fechaNacimiento = this.FechaNacimiento,
                    nacionalidad = this.Nacionalidad,

                    //Datos de direccion
                    idDireccion = this.direccion.idDireccion,
                    calle = this.direccion.Calle,
                    numeroExterior = this.direccion.NumeroExterior,
                    numeroInterior = this.direccion.NumeroInterior,
                    colonia = this.direccion.Colonia,
                    municipio = this.direccion.Municipio,
                    estado = this.direccion.Estado,
                    codigoPostal = this.direccion.CodigoPostal,

                    //Datos de Empleado
                    idEmpleado = this.idEmpleado,
                    RFC = this.RFC,
                    puesto = this.Puesto,
                    fechaIngreso = this.FechadeIngreso,
                    salarioDiario = this.SalarioDiario,
                    NSS = this.NSS,
                    horario = this.Horario,
                    totalFaltas = this.TotalFaltas,
                    activo = this.Activo,
            };

            return parametros;
        }

    }
}