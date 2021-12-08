using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Inicio
            //2.- Leer el valor de A , B y C
            Console.Write("Introduce el valor de A");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduce el valor de B");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Introduce el valor de C");
            int c = int.Parse(Console.ReadLine());

            //3.- Validar si A  > B
            if (a > b)
            {
                //3.1.- Si A es mayor, validar A < C
                if (a > c)
                {
                    //3.1.2.- Si A es mayor, validar B < C
                    if (b < c)
                    {
                        //3.1.2.1.- Si B es menor, EL MAXIMO ES A Y EL MINIMO ES B
                        Console.WriteLine("EL MAXIMO ES A");
                        Console.WriteLine("EL MINIMO ES B");
                    }
                    else
                    {
                        //3.1.2.2.- Si B no es menor, EL MAXIMO ES A Y EL MINIMO ES C
                        Console.WriteLine("EL MAXIMO ES A");
                        Console.WriteLine("EL MINIMO ES C");
                    }
                }
                else
                {
                    //3.1.3.- Si A no es mayor, EL MAXIMO ES C Y EL MINIMO ES B
                    Console.WriteLine("EL MAXIMO ES C");
                    Console.WriteLine("EL MINIMO ES B");
                }

            }
            else
            {
                //3.2.- Si A no es mayor, validar si B > C
                if (b > c)
                {
                    //3.2.1.- Si B es mayor, Validar A < C
                    if (a < c)
                    {
                        //3.2.1.1.- Si A es menor, EL MAXIMO ES B Y EL MINIMO ES A
                        Console.WriteLine("EL MAXIMO ES B");
                        Console.WriteLine("EL MINIMO ES A");
                    }
                    else
                    {
                        //3.2.1.2.- Si A no es menor, El MAXIMO ES B Y EL MINIMO ES C
                        Console.WriteLine("EL MAXIMO ES B");
                        Console.WriteLine("EL MINIMO ES C");
                    }
                }
                else
                {
                    //3.2.2.- Si B no es mayor, EL MAXIMO ES C Y EL MINIMO ES A
                    Console.WriteLine("EL MAXIMO ES C");
                    Console.WriteLine("EL MINIMO ES A");
                }
            }
            //4.- Fin      

            if(a > b && a > c)
            {
                Console.WriteLine("EL MAXIMO ES A");
                if(b < c)
                    Console.WriteLine("EL MINIMO ES B");
                else
                    Console.WriteLine("EL MINIMO ES C");
            }

            if(b > a && b > c)
            {
                Console.WriteLine("EL MAXIMO ES B");
                if(a < c)
                    Console.WriteLine("EL MINIMO ES A");
                else
                    Console.WriteLine("EL MINIMO ES C");
            }

            if(c > a && c > b)
            {
                Console.WriteLine("EL MAXIMO ES C");
                if(a < c)
                    Console.WriteLine("EL MINIMO ES A");
                else
                    Console.WriteLine("EL MINIMO ES B");
            }


        }
    }
}
