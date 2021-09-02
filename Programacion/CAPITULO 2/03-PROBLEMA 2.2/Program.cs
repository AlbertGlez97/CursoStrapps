using System;

namespace _03_PROBLEMA_2._2
{
    class Program
    {
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
