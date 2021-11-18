using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.- Inicio 
            // 2.- Se declara e inicializa A = 5,  B = 10 y C = 20
            int A = 5, B = 10 , C = 20;
            // 3.- Declara la variable AUX
            int AUX;
            // 4.- Asignacion AUX = B			//AUX = 10, A=5 , B=10 , C=20
            AUX = B ;
            // 5.- Asignacion B = A             //AUX = 10, A=5 , B=5 , C=20
            B = A ;
            // 6.- Asignacion A = C 			//AUX = 10, A=20 , B=5, C=20 
            A = C ;
            // 6.- Asignacion c = AUX			//AUX = 10, A=20 , B=5, C=10
            C = AUX;
            // 9.- IMPRIMIR EL "VALOR DE B :" + VALOR
            Console.WriteLine($"EL VALOR DE B: {B}");
            // 10.- IMPRIMIR EL "VALOR DE C :" + VALOR
            Console.WriteLine($"EL VALOR DE C: {C}");
            // 11.- IMPRIMIR EL "VALOR DE A :" + VALOR
            Console.WriteLine($"EL VALOR DE A: {A}");
            // 12.- FIN
        }
    }
}
