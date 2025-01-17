using System;

namespace Ejercicio23
{
    internal class Program
    {
        static int CalcularPuntos(int pG, int pE, int pP)
        {
            int puntG = 3;
            int puntE = 1;
            int puntP = 0;

            return pG * puntG + pE * puntE + pP * puntP;
        }

        static void Main(string[] args)
        {
            int partG;
            int partE;
            int partP;
            int pTotal;

            Console.Write("Partidos ganados: ");
            partG = int.Parse(Console.ReadLine());

            Console.Write("Partidos empatados: ");
            partE = int.Parse(Console.ReadLine());

            Console.Write("Partidos perdidos: ");
            partP = int.Parse(Console.ReadLine());

            pTotal = CalcularPuntos(partG, partE, partP);
            Console.WriteLine($"El equipo ha conseguido un total de {pTotal} puntos.");
        }
    }
}
