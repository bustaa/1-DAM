using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;

            Console.WriteLine("Introduce los 3 numeros: ");

            Console.Write("Numero 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numero 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numero 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 != n2 && n1 != n3 && n2 != n3)
            {
                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine($"El numero mayor es el {n1}");
                }
                else if (n2 > n3)
                {
                    Console.WriteLine($"El numero mayor es el {n2}");
                }
                else
                {
                    Console.WriteLine($"El numero mayor es el {n3}");
                }
            }
            else 
            {
                Console.WriteLine("Los numeros deben de ser distintos");
            }
        }
    }
}