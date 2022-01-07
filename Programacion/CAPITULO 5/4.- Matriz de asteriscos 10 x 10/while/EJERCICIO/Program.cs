using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=1, saltoLinea = 1;
            
            
            while(contador <= 10){

                while(saltoLinea <= 10){
                    Console.Write("* ");
                    saltoLinea ++;
                }

                Console.WriteLine();
                saltoLinea=1;

                contador++;
            }
        }
    }
}
