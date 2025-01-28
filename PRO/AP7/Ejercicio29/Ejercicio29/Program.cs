using System;

namespace Ejercicio29
{
    class Program
    {
        static void LlenarArray(double[] arr)
        {
            double num;
            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                pos++;
                Console.Write($"Introduce un numero para la posición {pos}: ");
                num = double.Parse(Console.ReadLine());
                arr[i] = num;
            }
        }

        static void VisualizarArr(double[] arr)
        {
            int pos = 0;
            foreach (double num in arr)
            {
                pos++;
                Console.WriteLine($"Posición {pos}: {num}");
            }
        }

        static void Main(string[] args)
        {
            double[] arrNums = new double[10];
            LlenarArray(arrNums);
            VisualizarArr(arrNums);
        }
    }
}
