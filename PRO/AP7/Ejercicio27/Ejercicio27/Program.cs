using System;

namespace Ejercicio27
{
    class Program
    {
        static double CalculaPrecio(double pr, double desc, float tax)
        {
            double prFinal = pr - pr * (desc / 100);
            prFinal += prFinal * tax;
            return prFinal;
        }

        static void Main(string[] args)
        {
            double precio;
            double porcDesc;
            const float IVA = 0.16f;

            do
            {
                Console.Write("Introduce el precio (0 para salir): ");
                precio = double.Parse(Console.ReadLine());

                if (precio != 0)
                { 
                    Console.Write("Introduce el descuento (0 - 20 %): ");
                    porcDesc = double.Parse(Console.ReadLine());
                
                    if (porcDesc < 0 || porcDesc > 20) porcDesc = 0;

                    precio = CalculaPrecio(precio, porcDesc, IVA);
                    Console.WriteLine($"Precio final: {precio:F2}");
                }
            } while (precio != 0);

        }
    }
}
