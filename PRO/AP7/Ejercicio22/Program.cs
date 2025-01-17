using System;

namespace Ejercicio22
{
    class Program
    {
        static int DiferenciaEdad(int edad1, int edad2)
        {
            return Math.Abs(edad1 - edad2);
        }

        static void Main(string[] args)
        {
            int edadHer1;
            int edadHer2;
            int difEdad;

            Console.Write("Introduce la edad del hermano 1: ");
            edadHer1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce la edad del hermano 2: ");
            edadHer2 = int.Parse(Console.ReadLine());

            difEdad = DiferenciaEdad(edadHer1, edadHer2);
            Console.WriteLine($"La diferencia de edad entre los dos hermanos es de: {difEdad} años");
        }
    }
}
