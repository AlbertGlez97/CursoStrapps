using System;

namespace _08_PROBLEMA_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Inicio
            //- Declaramos la variable numero
            int numero = 0;
            //Se declara la variable suma, donde se alamacenara el resultado
            int suma = 0;
            do
            {

                //Se pone una condicion en la cual se filtran los numeros pares 
                if (numero % 2 == 0)
                {

                    // Solamente se suman los numeros pares, se almacenada el valor y procede con el recorrido
                    suma += numero;
                }
                
                numero++;
            } while (numero <= 100);

            Console.WriteLine("La suma de los numeros pares comprendidos entre 2 y 100 es: "+ suma);
        }
    }
}
