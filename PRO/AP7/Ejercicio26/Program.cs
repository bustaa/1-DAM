using System;

namespace Ejercicio26
{
    internal class Program
    {
        static bool Primo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;

            Console.Write("Introduce un numero: ");
            n = int.Parse(Console.ReadLine());

            if (Primo(n))
            {
                Console.WriteLine($"El numero {n} es primo");
            }
            else
            {
                Console.WriteLine($"El numero {n} no es primo");
            }
        }
    }
}
