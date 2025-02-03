using System;

namespace Ejercicio03
{
        class Program
    {
        static void Main(string[] args)
        {
            Cuadrilatero c1 = new Cuadrilatero(12.234, 15.5);
            Cuadrilatero c2 = new Cuadrilatero(10.2);

            Console.WriteLine("Cuadrilatero 1:");
            Console.WriteLine($"Area: {c1.CalcularArea()}");
            Console.WriteLine($"Perimetro: {c1.CalcularPerimetro()}");

            Console.WriteLine("Cuadrilatero 2:");
            Console.WriteLine($"Area: {c2.CalcularArea()}");
            Console.WriteLine($"Perimetro: {c2.CalcularPerimetro()}");
        }
    }
}
