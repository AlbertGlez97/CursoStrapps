using System;

namespace _05_PROBLEMA_2._5
{
    class Program
    {

       /*  EJEMPLO 2.5
        Se desea diseñar un algoritmo para saber si un número es primo o no.
        Un número es primo si sólo puede dividirse por sí mismo y por la unidad (es decir, no tiene más divisores que él mismo y la unidad). Por ejemplo, 9, 8, 6, 4, 12, 16, 20, etc., no son primos, ya que son divisibles por números distintos a ellos mismos y a la unidad. Así, 9 es divisible por 3, 8 lo es por 2, etc. El algoritmo de resolución del problema pasa por dividir sucesivamente el número por 2, 3, 4..., etc. */
        static void Main(string[] args)
        {
           
             Console.WriteLine("Digita el numero a comparar");
             Decimal primo=Convert.ToInt32(Console.ReadLine());

             for(int i=2; i<=primo; ++i){

                 Decimal division = primo / i;
                 Console.WriteLine(division);

                //Si es un numero entero no es primo
                 if(division % 2 == 0){
                      Console.WriteLine("El numero "+primo+" no es primo");
                      break;
                 }

                 if(i == primo){
                     Console.WriteLine("El numero "+primo+" es primo");
                 }
             }

             
        }
    }
}
