using System;
using System.Collections.Generic;

namespace _09_EJEMPLO_2._9
{
    class Program
    {
        //1- Definir una varibale global llamda banco de datos
        static List<Empleado> bancoDeDatos= null;
        static void Main(string[] args)
        {
            //1. Inicio
            //2- Mandar a llamar el CreaBancoDeDatos
            CrearBancoDeDatos();

            //3- Mandar a llamar el RegistraEmpleado con los siguientes datos:
            RegistraEmpleado(1,"Juanito Perez",55,180);
            RegistraEmpleado(2,"Daniel Perez",35,150);
            RegistraEmpleado(3,"Fernando Gomez",40,200);
            RegistraEmpleado(4,"Maria Hernandez",0,300);
            RegistraEmpleado(5,"Pedro Salas",100,40);

            //Imprimir Encabezado
            ImprimirEncabezado();

            //4- Recorrer lista de banco datos empleados
            foreach(Empleado empleado in bancoDeDatos)
            {
                //4.1- Declarar la varibale para empleado que se este iterando
                int pagoHorasSemanal, pagoHorasExtraSemanal;
                decimal pagoSemanal, pagoExtra, total;

                if(empleado.NumeroHorasTrabajadas > 40)
                {
                    pagoHorasSemanal=40;
                    pagoHorasExtraSemanal= empleado.NumeroHorasTrabajadas - pagoHorasSemanal ;
                }
                else
                {
                    pagoHorasSemanal = empleado.NumeroHorasTrabajadas;
                    pagoHorasExtraSemanal=0;
                }

                pagoSemanal = pagoHorasSemanal * empleado.SalarioPorHora;
                pagoExtra= pagoHorasExtraSemanal * empleado.SalarioPorHora * 1.5M;
                total = pagoSemanal + pagoExtra;

                //4.2- Imprimir los resultados
                ImprimirResultado(empleado,pagoHorasSemanal, pagoHorasExtraSemanal, pagoSemanal, pagoExtra, total);

            }
        }

        static void ImprimirResultado(Empleado empleado, int pPagoHorasSemanal,int pPagoHorasExtraSemanal,decimal pPagoSemanal,decimal pPagoExtra,decimal pTotal)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t",
            empleado.NumeroEmpleado,
            empleado.Nombre,
            empleado.NumeroHorasTrabajadas,
            empleado.SalarioPorHora,
            pPagoHorasSemanal,
            pPagoHorasExtraSemanal,
            pPagoSemanal,
            pPagoExtra,
            pTotal);
        }

        static void ImprimirEncabezado()
        {
            string tNumeroEmpleado = "Numero Empleado";
            string tNombre = "Nombre";
            string tNumeroHorasTrabajadas= "Numero Horas Trabajadas";
            string tSalarioPorHora = "Salario Por Hora";
            string tPagoHorasSemana = "Pago Horas Semanal";
            string tPagoHorasExtraSemanal = "Pago Horas Extra Semanal";
            string tPagoSemanal= "Pago semanal";
            string tPagoExtra= "Pago extra";
            string tTotal= "Total";


            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t",
            tNumeroEmpleado,
            tNombre,
            tNumeroHorasTrabajadas,
            tSalarioPorHora,
            tPagoHorasSemana,
            tPagoHorasExtraSemanal,
            tPagoSemanal,
            tPagoExtra,
            tTotal);
            Console.WriteLine("=========================================================================================");
        }

        static void RegistraEmpleado(int numeroEmpleado, string nombre, int numeorHorasTrabajadas,  decimal salarioPorHora)
        {
            //1- Inicio
            //2- Recibe como parametor el numero Empleado, Nombre , Numero Horas trabajdas y Salario por hora
            //3- Crear un objeto los parametro recibidos
            Empleado empleado = new Empleado();

            empleado.NumeroEmpleado= numeroEmpleado;
            empleado.Nombre= nombre;
            empleado.NumeroHorasTrabajadas= numeorHorasTrabajadas;
            empleado.SalarioPorHora= salarioPorHora;

            //4 Agregar el objeto al banco de datos
            bancoDeDatos.Add(empleado);

        }

        static void CrearBancoDeDatos()
        {
            //1- Inicio
            //2- Crea bano de datos
            //2.1 - Definir la entidad Empleados
            //2.2 Crear la lista banco de datos
            bancoDeDatos = new List<Empleado>();
            //3- Fin
        }

        public class Empleado{
            public int NumeroEmpleado { get; set; }
            public string Nombre {get; set;}
            public int NumeroHorasTrabajadas { get; set; }
            public decimal SalarioPorHora { get; set; }
        }
    }
}
