using System;

/* El problema consiste en sumar 2 + 4 + 6 + 8 ... + 1.000. Utilizaremos las palabras SUMA y NÚMERO (variables,
serán denominadas más tarde) para representar las sumas sucesivas (2+4), (2+4+6), (2+4+6+8), etc.  */

namespace _06_PROBLEMA_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara la variable suma, donde se alamacenara el resultado
            int suma=0;

            //Utilizamos un ciclo en el cual vamos a recorrer los numeros del 2 al 1000
            for(int num=2; num <= 1000; num++)
            {   
                //Se pone una condicion en la cual se filtran los numeros pares 
                if(num % 2 == 0){

                    // Solamente se suman los numeros pares, se almacenada el valor y procede con el recorrido
                    suma += num;
                }
            }

            Console.WriteLine("La suma de los numeros pares del 2 al 1000 es "+suma);
        }
    }
}
