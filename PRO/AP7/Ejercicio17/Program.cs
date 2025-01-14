using System;
using System.Collections;

namespace Ejercicio17
{
    class Program
    {
        static int MinTemp(ArrayList arrTemps)
        {
            int minTemp = int.MaxValue;
            foreach (int temp in arrTemps)
            {
                if (temp < minTemp) minTemp = temp;
            }
            return minTemp;
        }

        static int MaxTemp(ArrayList arrTemps)
        {
            int maxTemp = int.MinValue;
            foreach (int temp in arrTemps)
            {
                if (temp > maxTemp) maxTemp = temp;
            }
            return maxTemp;
        }

        static void Main(string[] args)
        {
            ArrayList arrayTemps = new ArrayList();
            int tempMinima, tempMaxima, temp;

            do
            {
                Console.Write("Ingrese la temperatura: (99 para salir) ");
                temp = int.Parse(Console.ReadLine());
                if (temp != 99) arrayTemps.Add(temp);
            } while (temp != 99);

            if (arrayTemps.Count > 0)
            {
                tempMinima = MinTemp(arrayTemps);
                tempMaxima = MaxTemp(arrayTemps);
                Console.WriteLine($"Temperatura minima: {tempMinima}");
                Console.WriteLine($"Temperatura maxima: {tempMaxima}");
                Console.ReadKey();
            }
            
            Console.WriteLine("Fin de programa");
        }   
    }
}
