using System;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sueldos = new double[5];
            double sueldo = 0;
            int nEmpleado = 0;
            double media = 0, max = 0;

            for (int i = 0; i < sueldos.Length; i++)
            {
                nEmpleado++;
                Console.Write($"Introduce el sueldo del empleado {nEmpleado}: ");
                sueldo = Convert.ToDouble(Console.ReadLine());
                sueldos[i] = sueldo;
            }

            foreach (double sueldoEmp in sueldos)
            {
                media += sueldoEmp;
                if (sueldoEmp > max)
                {
                    max = sueldoEmp;
                }
            }

            media /= sueldos.Length;
            Console.WriteLine($"La media de sueldos es: {media:F2}");

            Console.WriteLine($"El suledo máximo es: {max:F2}");
        }            
    }
}
