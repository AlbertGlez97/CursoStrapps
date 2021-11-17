using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio.- Determinar la cantidad total a pagar por una llamada telefonica,
            //teniendo en cuenta lo siguiente:
            //* Toda llamada que dure menos de tres minutos (cinco pasos) tiene un coste de 10 centimos
            //* Cada minuto adicional a partir de los tres primeros es un paso de contador y cuesta 5 centimos
            //1.- Inicio
            //2.- Leer la duracion de la llamada y asignarla a duracion
            Console.Write("Introduce la duracion de la llamada: ");
            string sDuracion = Console.ReadLine();
            int duracion = int.Parse(sDuracion);
            //3.- Declarar variables totalPagar , resto
            int totalPagar, resto;
            //4.- Asignar totalPagar = 10
            totalPagar = 10;
            //5.- Valida si la duracion es mayor a 3 minutos
            if(duracion > 3){
                //5.1.- Si la duracion es mayor a 3 minutos
                    //resto = duracion - 3
                    resto = duracion - 3;
                    // totalPagar = totalPagar + resto * S
                    totalPagar = totalPagar + resto * 5;
            }
            //6.- El totla a pagar es totalPagar
            Console.WriteLine($"Total a pagar es: {totalPagar}");
            //7.- Fin
        }
    }
}
