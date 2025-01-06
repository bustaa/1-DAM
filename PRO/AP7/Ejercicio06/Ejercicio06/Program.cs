using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            char vocal;
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int pos = 0;

            Console.Write("Introduce la vocal: ");
            vocal = Convert.ToChar(Console.ReadLine());

            foreach (int i in vocales)
            {
                pos++;
                if (i == vocal) {
                    Console.WriteLine($"La posición de la vocal {vocal} es: {pos}");
                }
            }
        }
    }
}