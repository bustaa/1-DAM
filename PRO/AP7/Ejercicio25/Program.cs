using System;

namespace Ejercicio25
{
    class Program
    {
        static int CalculaSuma(int limIn, int limSu)
        {
            int suma = 0;
            for (int i = ++limIn; i < limSu; i++)
            {
                if (i % 2 == 0) suma += i;
            }
            return suma;
        }

        static void Main(string[] args)
        {
            int n1;
            int n2;
            int suma;
            ;
            Console.Write("Introduce el límite inferior: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el límite sueprior: ");
            n2 = int.Parse(Console.ReadLine());

            suma = CalculaSuma(n1, n2);
            Console.WriteLine($"La suma de los numeros pares comprendidos entre {n1} y {n2} es: {suma}");
        }
    }
}
