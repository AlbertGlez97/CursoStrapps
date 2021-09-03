using System;

namespace _05_PROBLEMA_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double division;

             Console.WriteLine("Digita el numero a comparar");
             int primo=Convert.ToInt32(Console.ReadLine());

             for(int i=2; i<=primo; ++i){

                 division = primo / i;
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
