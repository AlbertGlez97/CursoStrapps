using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.-Inicio
            //2.-Leer un numero y asignarlo a NUMERO
            Console.WriteLine("Introduzca un numero :");
            int numero = int.Parse(Console.ReadLine());
            //3.-Segun sea NUMERO hacer:
            //    case -9 a 9
            //          Imprimir el numero tiene 1 Digito
            //          fin_caso
            //    case -99 a 99
            //          Imprimir el numero tiene 2 Digito
            //          fin_caso
            //    case -999 a 999
            //          Imprimir el numero tiene 3 Digito
            //          fin_caso
            //    otros:
            //          Imprimir el numero tiene mas 3 digitos
            //          fin_caso
            switch (numero)
            {
                case int n when (-9 <= n && n <= 9):
                    Console.WriteLine("El numero tiene 1 Digito");
                    break;
                case int n when (-99 <= n && n <= 99):
                    Console.WriteLine("El numero tiene 2 Digito");
                    break;
                case int n when (-999 <= n && n <= 999):
                    Console.WriteLine("El numero tiene 3 Digito");
                    break;
                default:
                    Console.WriteLine("El numero tiene mas 3 Digito");
                    break;
            }
            //4.- Fin   

        }
    }
}
