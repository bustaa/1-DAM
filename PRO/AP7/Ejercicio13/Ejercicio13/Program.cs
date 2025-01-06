using System;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsLoteria = new int[6];
            
            Random rnd = new Random();

            for (int i = 0; i < numsLoteria.Length; i++)
            {
                numsLoteria[i] = rnd.Next(1, 49);
            }

            foreach (int number in numsLoteria)
            {
                Console.WriteLine(number);
            }
        }
    }
}
