using System;

namespace _04_PROBLEMA_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer pedido 
            Console.WriteLine("Cual es su pedido");
            String pedido=Console.ReadLine();

            Console.WriteLine("Es solvente \n Digite 1- Si es solvente \n Digite 2- No es solvente");
            int solvente=Convert.ToInt32(Console.ReadLine());

            switch(solvente){
                case 1:
                    Console.WriteLine("Su pedido : "+pedido+" fue aceptado");
                    break;
                case 2:
                    Console.WriteLine("Su pedido : "+pedido+" fue rechazado");
                    break;
                default:
                    Console.WriteLine("Digite una opcion valida");
                    break;
            }
                
        }
    }
}
