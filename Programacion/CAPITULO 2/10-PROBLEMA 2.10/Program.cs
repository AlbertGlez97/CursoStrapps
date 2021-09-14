using System;

namespace _10_PROBLEMA_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Inicio
            // 2- Definir el arreglo
            int[] arreglo ={5,3,0,2,4,4,0,0,2,3,6,0,2};

            //3- Declarar e innicializar el contador =0
            int contador = 0;

            //4- Repetir 0 hasta la longitud del arreglo(13)
            for(int interacion =0; interacion < arreglo.Length; interacion++)
            {
                //4.1 - Obtner el numoer en el arreglo en la posicion o iteracion actual
                int numero = arreglo[interacion];

                //4.2 - Validar el numero si es iguak a 0
                if(numero == 0)
                {
                    contador++;
                }

            }

            //5- Mostrar el numero de 0 encontrados
            Console.WriteLine("Se encontraron {0} ceros",contador);


        }
    }
}
