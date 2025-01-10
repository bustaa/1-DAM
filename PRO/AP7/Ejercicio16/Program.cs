using System;
using System.Collections;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList temperatura = new ArrayList();
            float temp;
            float tempMax = float.MinValue, tempMin = float.MaxValue;
            float promedio = 0;

            do
            {
                Console.Write("Dime una temperatura: ");
                temp = float.Parse(Console.ReadLine());
                if (temp != 99)
                {
                    temperatura.Add(temp);
                    promedio += temp;
                }

            } while (temp != 99);
        }
    }
}
