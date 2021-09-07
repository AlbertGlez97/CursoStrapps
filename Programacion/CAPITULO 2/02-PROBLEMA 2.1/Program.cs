using System;

namespace _02_PROBLEMA_2._1
{
    class Program
    {
        /* EJEMPLO 2.1
        Calcular la paga neta de un trabajador conociendo el número de horas trabajadas, la tarifa horaria y la tasa de
        impuestos. */
        static void Main(string[] args)
        {
           //Leer Horas, Tarifa, Tasa 
            Console.WriteLine("Ingrese horas trabajadas");
            double horas=Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ingrese tarifa horaria");
            double tarifa=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese tasa de impuestos");
            double tasa=Convert.ToDouble(Console.ReadLine());

            //Calcular
            double pagaBruta = horas * tarifa;

            double impuestos = pagaBruta * tasa;

            double pagaNeta = pagaBruta - impuestos;

            //Visualizar
            Console.WriteLine("PagoBruto: "+ pagaBruta);
		    Console.WriteLine("Impuestos: "+ impuestos);
		    Console.WriteLine("pagaNeta: "+ pagaNeta);

        }
    }
}
