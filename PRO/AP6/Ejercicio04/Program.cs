using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** CONTROL DE VENTA DE PRODUCTOS ** ");
            Console.WriteLine(" ");

            double precio;
            int cantidad;

            Console.Write("Ingrese precio del producto: $ ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad comprada: ");
            cantidad = int.Parse(Console.ReadLine());

            double importe = cantidad * precio;
            double descuento = 11 / 100.0 * importe;
            double total = importe - descuento;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("IMPORTE TOTAL: $ " + importe.ToString("0.00"));
            Console.WriteLine("DESCUENTO    : $ " + descuento.ToString("0.00"));
            Console.WriteLine("TOTAL A PAGAR: $ " + total.ToString("0.00"));

            Console.ReadKey();
        }
    }
}