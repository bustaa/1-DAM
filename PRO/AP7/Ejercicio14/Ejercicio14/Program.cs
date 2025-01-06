using System;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limInferior;
            int limSuperior;
            int sumaImpares = 0;

            Console.Write("Introduce el límite inferior: ");
            limInferior = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el límite superior: ");
            limSuperior = Convert.ToInt32(Console.ReadLine());

            for (int i = limInferior; i < limSuperior; i++)
            {
                if (i % 2 != 0)
                {
                    sumaImpares += i;
                }
            }

            Console.WriteLine($"La suma de los numeros impares comprendidos entre {limInferior} y {limSuperior} es: {sumaImpares}");
        }
    }
}
