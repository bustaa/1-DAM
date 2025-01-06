using System;


namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNums = 0;
            int nPar = 0;
            int nImpar = 0;
            int num;

            do
            {
                Console.Clear();
                
                Console.Write("Introduce un numero (0 para salir): ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num != 0) {
                    totalNums++;
                    if (num % 2 == 0)
                    {
                        nPar++;
                    }
                    else 
                    {
                        nImpar++;
                    }
                }
            } while (num != 0);

            Console.WriteLine($"Numeros totales {totalNums}");
            Console.WriteLine($"Numeros pares {nPar}");
            Console.WriteLine($"Numeros impares {nImpar}");
        }
    }
}
