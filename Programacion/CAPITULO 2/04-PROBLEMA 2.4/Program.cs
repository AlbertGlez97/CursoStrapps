using System;
using System.Collections.Generic;

namespace _04_PROBLEMA_2._4
{
    class Program
    {

        /*  EJEMPLO 2.4
         Un cliente ejecuta un pedido a una fábrica. La fábrica examina en su banco de datos la ficha del cliente, si el cliente es solvente entonces la empresa acepta el pedido; en caso contrario, rechazará el pedido. Redactar el algoritmo correspondiente. */
        static void Main(string[] args)
        {
            // 1- Inico
            // 2 - Pedir el numero de cliente
            Console.WriteLine("Introduce el numero de liente:");
            int numeroCliente = int.Parse(Console.ReadLine());

            // 3- Buscar al cliente dentro del banco de datos -> Esto manda a llamar a un subAlgoritmo 2
            Cliente cliente = BuscarCliente(numeroCliente);

            // 4- Pedir al cliente el total del pedido
            Console.WriteLine("Introduce el total del pedido:");
            decimal totalPedido = decimal.Parse(Console.ReadLine());

            if (cliente != null)
            {

                // 5- Validar si el cliente es solvente contra el total del pedio
                if (cliente.Saldo > totalPedido)
                {
                    //Si es solvente se acepta el pedido
                    Console.WriteLine("Tu pedido fue aceptado");
                }
                else
                {
                    //Si no es solvente se rechazado el pedido
                    Console.WriteLine("Tu pedido fue rechazado");
                }
            }
            else
            {
                Console.WriteLine("Elcliente no existe");
            }

        }
        //2- Busqueda y regresa un cliente
        static Cliente BuscarCliente(int numeroCliente)
        {
            //1- Inicio
            //2- Recibir el parametrode numero cliente

            //3- Crear y obtener el banco de datos -> Esto manda a llamr un subAlgoritmo
            List<Cliente> bancoDeDatos = CreaBancoDatos();
            //4- Buscar dentro de banco de datos el numero de cliente

            //5- Repartir hasta encontrar el cliente con el numero cliente que ser recibio por parametro
            foreach (Cliente cliente in bancoDeDatos)
            {

                //5.1- Valida si existe el numero de cliente en banco de datos
                if (cliente.NumeroCliente == numeroCliente)
                {
                    //5.1.1- Si existe se regresa el cliente
                    return cliente;
                }

            }
            //6- El cliente no existio regresamos nada
            return null;
            //7- Fin

        }

        // Crea y regresa un banco de datos
        static List<Cliente> CreaBancoDatos()
        {
            //1- Inicio
            //2- Definir la entidad Cliente para el banco  de datos (Definir una clase)
            //3- Vamos a crear el cliente y aguardar 5 cliente en el banco de datos (Esto va ser de manera constante)
            List<Cliente> bancoDeDatos = new List<Cliente>();

            //3.1- Vamos a crera el cliente -> Asiganr el numero, nombre y el saldo
            Cliente cliente = new Cliente();
            cliente.NumeroCliente = 1;
            cliente.Nombre = "Juanito Perez";
            cliente.Saldo = 1000;
            bancoDeDatos.Add(cliente);

            cliente = new Cliente();
            cliente.NumeroCliente = 2;
            cliente.Nombre = "Emiliano Hernandez";
            cliente.Saldo = 1100;
            bancoDeDatos.Add(cliente);

            cliente = new Cliente();
            cliente.NumeroCliente = 3;
            cliente.Nombre = "Fernanda Gonzalez";
            cliente.Saldo = 2000;
            bancoDeDatos.Add(cliente);

            cliente = new Cliente();
            cliente.NumeroCliente = 4;
            cliente.Nombre = "Luis Sanchez";
            cliente.Saldo = 500;
            bancoDeDatos.Add(cliente);

            cliente = new Cliente();
            cliente.NumeroCliente = 5;
            cliente.Nombre = "Estefania Gomez";
            cliente.Saldo = 0;
            bancoDeDatos.Add(cliente);

            //3.2- Vamos a guarda el cliente en el banco

            return bancoDeDatos;
            //4- Regresamos el banco de datos
            //5- Fin

        }

        //2- Definir la entidad Cliente para el banco  de datos (Definir una clase)
        public class Cliente
        {
            public int NumeroCliente { get; set; }
            public string Nombre { get; set; }
            public decimal Saldo { get; set; }


        }
    }
}
