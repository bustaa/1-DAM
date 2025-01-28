using System;
using System.Runtime.InteropServices;

namespace Ejercicio28
{
    class Program
    {
        static double CalculaMedia(Array arr)
        {
            double total = 0;
            foreach (int n in arr)
            {
                total += n;
            }
            return total / arr.Length;
        }

        static void Main(string[] args)
        {
            int[] arrNums = new int[5];
            double media;
            int num;

            Console.WriteLine("Introduce los numeros enteros: ");

            for (int i = 0; i < arrNums.Length; i++)
            {
                num = int.Parse(Console.ReadLine());
                arrNums[i] = num;
            }

            media = CalculaMedia(arrNums);
            Console.WriteLine($"La media de los numeros introducidos es: {media}");
        }
    }
}
