using System;
using System.Collections.Generic;

/*Cálculo de los salarios mensuales de los empleados de una empresa, sabiendo que éstos se calculan en base a las horas semanales trabajadas y de acuerdo a un precio especificado por horas. Si se pasan de cuarenta horas semanales, las horas extraordinarias se pagarán a razón de 1,5 veces la hora ordinaria. */
namespace _09_PROBLEMA_2._9
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Empleado> bancoDeDatos = CreaBancoDatos();


            Console.WriteLine("Numero  |Nombre              | Horas Trabajadas | Salario x Hora | Horas Semana  |  Horas extras |   Pago Semanal  |  Pago extra | Total");

            foreach (Empleado empleado in bancoDeDatos)
            {
                decimal horasSemana = 0;
                decimal horasExtras = 0;
                decimal pagoSemanal = 0;
                decimal pagoExtra = 0;
                decimal total = 0;

                if (empleado.horasTrabajadas > 40)
                {
                    horasSemana = 40;
                    horasExtras = empleado.horasTrabajadas - horasSemana;
                    pagoExtra = (1.5M * empleado.salarioHora) * horasExtras;
                    pagoSemanal = (40 * empleado.salarioHora);
                    total = pagoExtra + pagoSemanal;

                }
                else
                {
                    horasSemana = empleado.horasTrabajadas;
                    pagoSemanal = horasSemana * empleado.salarioHora;
                    total = pagoSemanal;

                }

            Console.WriteLine("  {0}     {1}\t                {2}             {3}            {4}                   {5}               {6}            {7}    {8} ", empleado.numeroEmpleado, empleado.nombre, empleado.horasTrabajadas, empleado.salarioHora, horasSemana, horasExtras, pagoSemanal, pagoExtra, total);
            }
        }

        static List<Empleado> CreaBancoDatos()
        {
            List<Empleado> bancoDeDatos = new List<Empleado>();

            Empleado empleado = new Empleado();
            empleado.numeroEmpleado = 1;
            empleado.nombre = "Juanito Perez";
            empleado.horasTrabajadas = 55;
            empleado.salarioHora = 180;
            bancoDeDatos.Add(empleado);

            empleado = new Empleado();
            empleado.numeroEmpleado = 2;
            empleado.nombre = "Daniel Perez";
            empleado.horasTrabajadas = 35;
            empleado.salarioHora = 150;
            bancoDeDatos.Add(empleado);

            empleado = new Empleado();
            empleado.numeroEmpleado = 3;
            empleado.nombre = "Fernando Gomez";
            empleado.horasTrabajadas = 40;
            empleado.salarioHora = 200;
            bancoDeDatos.Add(empleado);

            empleado = new Empleado();
            empleado.numeroEmpleado = 4;
            empleado.nombre = "Maria Hernandez";
            empleado.horasTrabajadas = 0;
            empleado.salarioHora = 300;
            bancoDeDatos.Add(empleado);

            empleado = new Empleado();
            empleado.numeroEmpleado = 5;
            empleado.nombre = "Pedro Solas";
            empleado.horasTrabajadas = 43;
            empleado.salarioHora = 100;
            bancoDeDatos.Add(empleado);

            return bancoDeDatos;
        }

        public class Empleado
        {
            public int numeroEmpleado { get; set; }
            public string nombre { get; set; }
            public int horasTrabajadas { get; set; }
            public decimal salarioHora { get; set; }
        }
    }
}
