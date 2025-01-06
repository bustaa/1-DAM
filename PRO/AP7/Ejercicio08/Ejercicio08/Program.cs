using System;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res = 0;

            Console.Write("Introduce el numero 1: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Introduce el numero 2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < n2; i++) {
                res += n1;
            }

            Console.WriteLine($"El resultado es {res}");
        }
    }
}
