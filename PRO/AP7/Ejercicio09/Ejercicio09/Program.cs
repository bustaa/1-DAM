using System;


namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplo = 3;
            int limInferior = 1;
            int limSuperior = 100;

            for (int i = limInferior; i < limSuperior; i++) 
            {
                if (i % multiplo == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
