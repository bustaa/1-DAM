using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 capacidad;
            double numCDs;
            int capacidadCD = 700;
            int gigabyte = 1024;

            Console.WriteLine("Introduce la capacidad alamacenada en el HD (en GB): ");
            capacidad = Convert.ToInt32(Console.ReadLine()) * gigabyte;

            numCDs = (double)capacidad / capacidadCD;

            if (numCDs != Math.Floor(numCDs))
            {
                numCDs = Math.Floor(numCDs) + 1;
                Console.WriteLine($"Se necesitarán un total de {numCDs} CDs");
            }
            else
            {
                Console.WriteLine($"Se necesitarán un total de {numCDs} CDs");
            }
        }
    }
}