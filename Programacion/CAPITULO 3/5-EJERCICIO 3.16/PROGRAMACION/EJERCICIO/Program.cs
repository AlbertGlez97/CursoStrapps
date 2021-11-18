using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
           //3.16 Escribir un algoritmo que calcule el producto de los n primeros numeros naturales
           // Analisis, el problema puede calcular el producto N * (N - 1) * (N* -2) * ...... * 3 * 2 * 1, que en terminos matematicos se le conoce con el nombre de FACTORIAL

           //1.- Inicio                 
           //2.- Leer el valor de N                     -> N =6
           Console.Write("Introduce un numero: ");
           string numero = Console.ReadLine();
           int n = int.Parse(numero);
           
           //3.- Declarar e inicializar contador = 2    -> N =6, contador =2
           int contador = 2;
           //4.- Declarar e inicializar factorial = 1   -> N =6, contador =2,factorial =1
           int factorial =1;
           //5.- Iterar mientras contador <= N
           while(contador <= n)
           {
               //5.1 Calcular el factorial, factorial = factorial * contador   ->N=6 ,contador =5, factorial=24 * = 120
               factorial = factorial * contador;
               //5.2 Incrementar contador en 1, contador = contador + 1        ->N=6 ,contador =6, factorial=120
                contador++;
           }
                
           //6.- Imprimir el resultado 
           Console.Write($"El factorial del numero {n} es: {factorial}");
           //7.- Fin
        }
    }
}
