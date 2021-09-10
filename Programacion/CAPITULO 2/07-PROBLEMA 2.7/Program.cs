using System;

/* Calcular la media de una serie de números positivos, suponiendo que los datos se leen desde un terminal. Un valor
de cero —como entrada— indicará que se ha alcanzado el final de la serie de números positivos. */

namespace _07_PROBLEMA_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Inicio
            //2- Declarar suma = 0
            int suma = 0; 

            //3- Declarar contador 0
            int contador =0;
            
            //4-Declarar numero
            int numero = 0; 
            
            //5-Hacer esto 
            do{
                //5.1 Obtener de la terminal un numero y guardar en la variable
                Console.WriteLine("Introduce numero");
                numero = int.Parse(Console.ReadLine());

                //5.2 Validar que numero que no sea 0(Numero se diferente de 0 numero !=0)
                if(numero !=0)
                {
                    //5.2.1 Agrega, acomula o suma el numero a la variable suma
                    suma += numero;

                    //5.2.2 Incremente contador en 1
                    contador++;
                }

            //6- Mientras numero no sea igual 0
            }while(numero !=0);

            //7- Calcular la media y guardar en la variable
            decimal media = suma /contador;

            Console.WriteLine("La media es "+media);
        }
    }
}
