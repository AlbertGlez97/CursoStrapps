using System;

namespace _11_PROBLEMA_2._11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Leer los tres valores, A, B y C
            Console.WriteLine("Introduce A");
            int numeroA = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce B");
            int numeroB = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce C");
            int numeroC = int.Parse(Console.ReadLine());

            
            
            //Guardar el resultado de la condicion en un booleano
            //Si A + B = C son "Iguales" == True
            Boolean comparacionUno = numeroA + numeroB == numeroC;

            //Imprimir el resultado, si es True imprime iguales 
            if(comparacionUno)
            {
                Console.WriteLine("A + B = C son `Iguales`");
            
            //Si no Disiguales
            }else{
                 Console.WriteLine("A + B = C `Disiguales`");
            }



            //Si A + C = B son "Iguales" == True
            Boolean comparacionDos = numeroA + numeroC == numeroB;

            //Imprimir el resultado, si es True imprime iguales
            if(comparacionDos)
            {
                Console.WriteLine("A + C = B son `Iguales`");
            }else{
                 Console.WriteLine("A + C = B son `Disiguales`");
            }




            //Si B + C = A son "Iguales" == True
            Boolean comparacionTres = numeroB + numeroC == numeroA;

            //Imprimir el resultado, si es True imprime iguales
            if(comparacionTres)
            {
                Console.WriteLine("B + C = A son `Iguales`");
            }else{
                 Console.WriteLine("B + C = A son `Disiguales`");
            }

            
        }
    }
}
