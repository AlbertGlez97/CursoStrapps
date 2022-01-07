using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Inicio
            //2.- Declarar las variables e inicializar
            int contador = 1,
                nota = 1,
                promedio = 0,
                suma = 0;
            //3.- La primera vez va entrar al ciclo do while, la segunda ves ,
            //tiene que cumplir con la condicion que nota igual -99 se rompe
            do{
            
                //4.- Imprimir el mensaje "Introduzca la nota del alumno" + contador
                Console.WriteLine($"Introduzca la nota del alumno {contador}");
                nota = int.Parse(Console.ReadLine());

                //5.- Si nota es diferente a -99
                if(nota != -99){
                    //5.1.- suma = suma + nota
                    suma += nota;
                    //5.2.-Incrementar contador
                    contador++;
                }
            }while(nota != -99);

            //6.- Decrementar contador 
            contador -= 1;

            //7.- Validar si el resultado contador es mayor que 0
            if(contador > 0){
                //6.- Calcular el promedio
                promedio = suma / contador;

                //7.- Imprimir el promedio de la nota            
                Console.WriteLine($"El promedio de la nota es {promedio}");
            }else{
                Console.WriteLine("Erro verifica");
            }   
            



        }
    }
}
