using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el numero de A: ");
           string numeroA = Console.ReadLine();
           int A = int.Parse(numeroA);
           Console.Write("Introduce el numero de B: ");
           string numeroB = Console.ReadLine();
           int B = int.Parse(numeroB);
           Console.Write("Introduce el numero de C: ");
           string numeroC = Console.ReadLine();
           int C = int.Parse(numeroC);

           if(A > B){
               if(A > C){
                   Console.Write($"La letra A con el valor: {A} es mas grande ");
               }else{
                   Console.Write($"La letra C con el valor: {C} es mas grande ");
               }
           }else{
               if(B > C){
                   Console.Write($"La letra B con el valor: {B} es mas grande ");
               }else{
                   Console.Write($"La letra C con el valor: {C} es mas grande ");
               }
           }

        }
    }
}
