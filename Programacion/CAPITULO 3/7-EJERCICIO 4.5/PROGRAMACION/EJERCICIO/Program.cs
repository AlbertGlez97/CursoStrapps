using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Inicio
            double salario_bruto;
            double impuestos;
            double salario_neto;

            // 2. Leer nombre, horas trabajadas, tarifa horaria.
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Horas trabajadas: ");
            string hora = Console.ReadLine();
            int horasTrabajadas = int.Parse(hora);

            Console.Write("Tarifa horaria: ");
            string tarifa = Console.ReadLine();
            int tarifaHoraria = int.Parse(tarifa);

            // 3. Verificar si horas trabajadas <= 35, en cuyo caso
            if (horasTrabajadas <= 35)
            {
                // 3.1 Salario_bruto = horas * tarifa; en caso contrario
                salario_bruto = horasTrabajadas * tarifaHoraria;
            }
            else
            {
                // 3.2 salario_bruto = 35 * tarifa + (horas - 35) * tarifa
                salario_bruto = 35 * tarifaHoraria + (horasTrabajadas - 35) * tarifaHoraria;
            }
            // 4. Calculo de impuestos
            // 4.1 Si salario_bruto <= 2.000, entonces impuestos = 0
            if (salario_bruto <= 2000)
            {
                impuestos = 0;

                // 4.2 Si salario_bruto <= 2.220, entonces
            }
            else if (salario_bruto <= 2220)
            {
                // 	impuestos = (salario_bruto - 2.000) * 0.20
                impuestos = (salario_bruto - 2000) * 0.2;

                // 4.3 Si salario_bruto > 2.220 entonces
            }
            else
            {
                // 	impuestos = (salario_bruto - 2.220) * 0.30 + (220 * 0.20)
                impuestos = (salario_bruto - 2220) * 0.3 + 220 * 0.2;
            }
            // 5. Calculo del salario_neto
            // 	salaraio_neto = salario_bruto - impuestos
            salario_neto = salario_bruto - impuestos;
            Console.Write($"El empleado '{nombre}' tiene un salario neto : {salario_neto}");
        }
    }
}
