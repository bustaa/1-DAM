using System;
using System.Collections;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numsPrimos = new ArrayList();
            int limInferior = 2;
            int limSuperior = 1000;
            bool esPrimo;

            for (int i = limInferior; i < limSuperior; i++)
            {
                esPrimo = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        esPrimo = false;
                    }
                }

                if (esPrimo)
                {
                    numsPrimos.Add(i);
                }
            }

            foreach (int num in numsPrimos)
            {
                Console.WriteLine(num);
            }
        }
    }
}
