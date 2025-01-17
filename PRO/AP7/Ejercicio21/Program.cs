using System;
using System.Runtime.Remoting.Messaging;

namespace Ejercicio21
{
    class Program
    {
        static bool EsMultiplo(int n, int mult)
        {
            if (n % mult == 0)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int num;
            int multiplo = 10;

            Console.Write("Introduce un numero: ");
            num = int.Parse(Console.ReadLine());

            if (EsMultiplo(num, multiplo))
            {
                Console.WriteLine($"{num} es multiplo de {multiplo}");
            }
            else
            { 
                Console.WriteLine($"{num} no es multiplo de {multiplo}");
            }
        }
    }
}
