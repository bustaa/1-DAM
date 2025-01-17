using System;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            double tax;
            double princeWithTax;
            int minTax = 16;
            int maxTax = 21;
            bool validTax;

            do {
                Console.Write("Introduce el precio (0 para salir): ");
                price = double.Parse(Console.ReadLine());

                do
                {
                    validTax = true;
                    Console.Write("Introduce el IVA: ");
                    tax = double.Parse(Console.ReadLine());

                    if (tax < minTax || tax > maxTax)
                    {
                        Console.WriteLine("El IVA debe estar entre el 16 y el 21%");
                        validTax = false;
                    }

                } while (!validTax);

                princeWithTax = price + price * (tax / 100);
                Console.WriteLine($"Precio sin IVA: {price}\nPrecio con IVA {princeWithTax:F2}");

            } while (price != 0);
            
        }
    }
}
