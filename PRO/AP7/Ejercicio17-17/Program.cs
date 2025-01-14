using System;

namespace Ejercicio17_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numRandom = rnd.Next(1, 100);
            int num;

            do
            {
                Console.Write("Introduce el numero aleatorio: ");
                num = int.Parse(Console.ReadLine());
                if (num == numRandom)
                {
                    Console.WriteLine($"Correcto, el numero era el {numRandom}");
                }
                else
                {
                    if (num < numRandom)
                    {
                        Console.WriteLine($"Error, el numero es mayor que {num}");
                    }
                    else
                    {
                        Console.WriteLine($"Error, el numero es menor que {num}");
                    }
                }
            } while (num != numRandom);
        }
    }
}
