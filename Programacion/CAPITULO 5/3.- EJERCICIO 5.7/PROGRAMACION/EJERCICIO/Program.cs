using System;
using System.Collections;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, digitoSig;
            string numInverso="";
            
            Console.WriteLine("Ingresa el numero a invertir");
            num = int.Parse(Console.ReadLine());

            while(num > 0){
                digitoSig = num % 10 ;
                num = num / 10;

                numInverso += digitoSig.ToString();

            }

            Console.WriteLine($"El numero invertido es {numInverso}");

        }
    }
}
