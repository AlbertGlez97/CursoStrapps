using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Inicio
            //2.- Leer un  numero y asignarlo a NUMERO
            Console.Write("Introduce un numero :");
            int numero = int.Parse(Console.ReadLine());
            //3.- Validar si Numero >= 1 y NUMERO <= 19
            if(numero >= 1 && numero <= 10)
            {
            //    3.1.- Si es valido
            //      3.1.1 Segun_sea NUMERO hacerl:
            //              Caso 1:
            //              Caso 3:
            //              Caso 5:
            //              Caso 7:
            //              Caso 9:
            //                  Escribir el mensaje de el NUMERO es impar
            //                  Fin_Casos
            //              Caso 2:
            //              Caso 4:
            //              Caso 6:
            //              Caso 8:
            //              Caso 10:
            //                  Escribir el mensaje de el NUMERO es impar
            //                  Fin_Casos
            //       Fin_segun
                switch(numero)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 9:
                        Console.WriteLine("El numero es impar");
                        break;
                    case 2:
                    case 4:
                    case 6:
                    case 8:
                    case 10:
                        Console.WriteLine("El numero es par");
                        break;
                }
            }
            else
            {
            //    3.2.- Si no es valido, imprimir el mensaje EL NUMERO no estaa en el rango de 1 al 10
                Console.WriteLine("El numero no esta en el rango del 1 al 10");
            }
            //4.- Fin



        }
    }
}
