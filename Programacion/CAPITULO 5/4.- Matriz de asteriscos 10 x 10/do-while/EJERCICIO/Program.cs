using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=1, saltoLinea = 1;
            do{

                do{
                    Console.Write("* ");
                    saltoLinea ++;
                }while(saltoLinea <= 10);
                Console.WriteLine();
                saltoLinea=1;

                contador++;
            }while(contador <= 10);
        }
    }
}
