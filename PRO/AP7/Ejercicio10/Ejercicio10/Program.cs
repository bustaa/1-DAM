using System;


namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSerie = 0;
            int limite = 1000;

            while (numSerie < limite)
            {
                numSerie += numSerie + 1;
                if (numSerie < limite)
                {
                    Console.WriteLine(numSerie);
                }
            }
        }
    }
}
