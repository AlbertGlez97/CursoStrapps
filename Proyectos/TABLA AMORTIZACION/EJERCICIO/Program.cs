using System;

namespace EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            float pago, Interes_pagado, Capital_pagado, Monto_del_prestamo, tasa_interes_anual, tasa_interes_mensual;
            int fila, Plazo, i,año,mes,dia;
            //ref y out permiten que el método llamado modifique un parámetro. La diferencia entre ellos es lo que sucede antes de usted hace la llamada.
            // -ref significa que el parámetro tiene un valor antes al entrar en la función. La función llamada puede leer y/o cambiar el valor en cualquier momento. El parámetro entra, luego sale
            // -out significa que el parámetro no tiene valor oficial antes de entrar en la función. La función llamada debe inicializarla. El parámetro solo sale
            Console.Write("Introduce el monto del prestamo: ");
            float.TryParse(Console.ReadLine(), out Monto_del_prestamo);
            Console.Write("Introduce la tasa de interes anual: ");
            float.TryParse(Console.ReadLine(), out tasa_interes_anual);
            Console.Write("Introduce el plazo en meses: ");
            int.TryParse(Console.ReadLine(), out Plazo);

            Console.WriteLine("Introduce la fecha de inicio");
            Console.Write("Introduce año:");
            int.TryParse(Console.ReadLine(), out año);
            Console.Write("Introduce mes:");
            int.TryParse(Console.ReadLine(), out mes);
            Console.Write("Introduce dia:");
            int.TryParse(Console.ReadLine(), out dia);

            //Obtenemos la fecha de inicio
            var dat = new DateTime(año,mes,dia);

            //Calculo del interes mensual
            tasa_interes_mensual = (tasa_interes_anual / 100) / 12;


            //Calculo de la cuota mensual
            //R = A * i / (1 – 1 / (1 + i)^n)
            // R: es la renta, es decir, el monto de la cuota a pagar cada mes, y el cual hay que calcular.
            // A: es el monto del crédito adquirido.
            // i: es la tasa de interés mensual que se debe pagar por el crédito.
            // n: es el número de meses durante los cuales se debe cancelar el crédito.
            pago = tasa_interes_mensual + 1;
            //Math.Pow(base, exponente); 
            pago = (float)Math.Pow(pago, Plazo);
            pago = pago - 1;
            pago = tasa_interes_mensual / pago;
            pago = tasa_interes_mensual + pago;
            pago = Monto_del_prestamo * pago;




            Console.WriteLine();
            fila = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Numero pago \t");
            Console.Write("Fecha vencimiento \t");
            Console.Write("Deuda \t");
            Console.Write("Pago capital \t\t");
            Console.Write("Pago interes \t\t");
            Console.Write("Saldo \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", Monto_del_prestamo);


            for (i = 1; i <= Plazo; i++)
            {
                Interes_pagado = tasa_interes_mensual * Monto_del_prestamo;
                Capital_pagado = pago - Interes_pagado;

                Console.Write("\t{0}\t", fila);

                Console.Write("{0}\t", dat.AddMonths(i).ToString("d"));

                Console.Write("\t{0}\t", Monto_del_prestamo);
                
                Console.Write("{0}\t", Capital_pagado);

                Console.Write("{0}\t", Interes_pagado);

                Monto_del_prestamo = Monto_del_prestamo - Capital_pagado;
                Console.Write("\t{0}\t", Monto_del_prestamo);

                fila = fila + 1;
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
