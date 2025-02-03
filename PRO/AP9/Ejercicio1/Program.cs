using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socio s1 = new Socio("JC", 18, 'M', 80, 1.70);
            Socio s2 = new Socio();

            Console.WriteLine("Información del primer socio:");
            Console.WriteLine("=============================");
            s1.Informa();
            Console.WriteLine($"{s1.Nombre} tiene un peso {s1.CalcularIMC()}");
            if (s1.EsMayorDeEdad())
            {
                Console.WriteLine($"{s1.Nombre} es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"{s1.Nombre} es menor de edad.");
            }

            Console.WriteLine("\nInformación del segundo socio: ");
            Console.WriteLine("=============================");
            s2.Informa();
            Console.WriteLine($"{s2.Nombre} tiene un peso {s2.CalcularIMC()}");
            if (s2.EsMayorDeEdad())
            {
                Console.WriteLine($"{s2.Nombre} es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"{s2.Nombre} es menro de edad.");
            }
        }
    }
}
