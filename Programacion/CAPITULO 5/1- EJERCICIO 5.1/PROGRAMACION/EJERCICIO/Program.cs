using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSumatoria =0,
                numeroIntroduce;

            Console.WriteLine("Introduzca la cantidad de nuemros que va ingresar:");
            int numeroCant = int.Parse(Console.ReadLine());

            if(numeroCant == 0) Console.WriteLine("Introduza un numero mayor a cero");

            while(numeroCant > 0){
                Console.WriteLine($"Introducas el numero {numeroCant}");
                numeroIntroduce = int.Parse(Console.ReadLine());

                numeroSumatoria += numeroIntroduce;

                numeroCant--;
            }

            Console.WriteLine($"La suma total es de {numeroSumatoria}");


        }
    }
}
