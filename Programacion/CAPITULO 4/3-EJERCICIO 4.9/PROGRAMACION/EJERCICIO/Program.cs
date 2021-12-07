using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Inicio
            //2- Leer el numero de dia y almacenarlo en NUMERO_DIA
            Console.WriteLine("Introduzca el numero de dia:");
            int numeroDia = int.Parse(Console.ReadLine());
            //3- Determinar el nombre del dia
            //   Segun_sea NUMERO_DIA hacer:
            //        caso 1:
            //              El dia es LUNES
            //              fin_caso
            //        caso 2:
            //              El dia es Martes
            //              fin_caso
            //        caso 3:
            //              El dia es Miercoles
            //              fin_caso
            //        otros:
            //              El dia no es VALIDO
            //      Fin_segun
            switch(numeroDia)
            {
                case 1:
                    Console.WriteLine("El dia es Lunes");
                    break;
                case 2:
                    Console.WriteLine("El dia es Martes");
                    break;
                case 3:
                    Console.WriteLine("El dia es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("El dia es Jueves");
                    break;
                case 5:
                    Console.WriteLine("El dia es Viernes");
                    break;
                case 6:
                    Console.WriteLine("El dia es Sabado");
                    break;
                case 7:
                    Console.WriteLine("El dia es Domingo");
                    break;
                default:
                    Console.WriteLine("El numero de dia no es valido");
                    break;
            }
            //4- Fin
        }
    }
}
