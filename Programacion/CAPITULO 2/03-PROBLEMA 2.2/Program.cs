using System;

namespace _03_PROBLEMA_2._2
{
    class Program
    {
       /*EJEMPLO 2.2
         Calcular el valor de la suma 1+2+3+...+100. */
        static void Main(string[] args)
        {
            int contador=1;
            int suma=0;
            while(contador <= 100)
            {
                suma+=contador;
                contador++;
            }
            Console.WriteLine(suma);
        }
    }
}
